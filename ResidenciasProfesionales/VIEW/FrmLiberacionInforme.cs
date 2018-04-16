using ResidenciasProfesionales.DATA;
using ResidenciasProfesionales.MODEL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ResidenciasProfesionales.VIEW
{
    public partial class FrmLiberacionInforme : Form
    {
        private String IdDocente;
        private String Matricula;
        private String Rol;
        private DictamenPOJO Dictamen;

        public FrmLiberacionInforme(String idDocente, String matricula)
        {
            IdDocente = idDocente;
            Matricula = matricula;
            Rol = RolDAO.ObtenerRol(matricula, idDocente).Rol;
            Dictamen = DictamenDAO.ObtenerDictamen(idDocente, matricula, "Aprobacion" + Rol);

            InitializeComponent();
            CargarDatosAlumno();

            if (Dictamen != null)
                CargarDatosDictamen();
        }
        private void btnEvaluar_Click(object sender, EventArgs e)
        {
            GuardarDatos();
        }

        private void CargarDatosAlumno()
        {
            var alumno = AlumnoDAO.ObtenerAlumno(Matricula);

            txtNoControl.Text = alumno.Matricula;
            txtNombre.Text = alumno.NombreCompleto;
            txtCarrera.Text = CarreraDAO.ObtenerUno(alumno.Carrera).Nombre;
            txtSemestre.Text = alumno.Semestre.ToString();
        }
        private void CargarDatosDictamen()
        {
            btnEvaluar.Enabled = false;
            txtComentarios.Enabled = false;
            txtComentarios.Text = Dictamen.Comentario;
        }
        private bool ValidarDatos()
        {
            return true;
        }
        private void GuardarDatos()
        {
            if (!ValidarDatos())
                return;

            DialogResult dr = MessageBox.Show("Continuar con el guardado", "Info",
                                              MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.No)
                return;

            var solicitud = SolicitudDAO.ObtenerSolicitud(Matricula);
            var idResidencia = solicitud.IdResidencia;
            var tipo = (Rol == "Asesor") ? "LiberacionAsesor" : "LiberacionRevisor";

            DictamenDAO.InsertarDictamen(
                new DictamenPOJO(-1,
                                 idResidencia,
                                 IdDocente,
                                 tipo,
                                 "Aceptado",
                                 txtComentarios.Text,
                                 0,
                                 DateTime.Now));

            Close();
        }

    }
}
