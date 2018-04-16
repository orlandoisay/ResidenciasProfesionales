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
    public partial class FrmAprobacionInforme : Form
    {
        private String IdDocente;
        private String Matricula;
        private String Rol;
        private DictamenPOJO Dictamen;

        public FrmAprobacionInforme(String idDocente, String matricula)
        {
            IdDocente = idDocente;
            Matricula = matricula;
            Rol = RolDAO.ObtenerRol(matricula, idDocente).Rol;
            Dictamen = DictamenDAO.ObtenerDictamen(idDocente, matricula, "Aprobacion" + Rol);

            InitializeComponent();
            CargarDatosAlumno();

            if(Dictamen != null)
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
            txtNombre.Text = string.Format("{0} {1}, {2}", alumno.ApellidoP, alumno.ApellidoM, alumno.Nombre);
            txtCarrera.Text = CarreraDAO.ObtenerUno(alumno.Carrera).Nombre;
            txtSemestre.Text = alumno.Semestre.ToString();
        }
        private void CargarDatosDictamen()
        {
            rbtnAprobar.Enabled = false;
            rbtnRechazar.Enabled = false;
            btnEvaluar.Enabled = false;
            txtComentarios.Enabled = false;

            if (Dictamen.Estatus == "Aceptado")
                rbtnAprobar.Checked = true;

            if (Dictamen.Estatus == "Rechazado")
                rbtnRechazar.Checked = true;

            txtComentarios.Text = Dictamen.Comentario;
        }
        private bool ValidarDatos()
        {
            if (!rbtnAprobar.Checked && !rbtnRechazar.Checked)
            {
                MessageBox.Show("Debe elegir un veredicto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
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
            var tipo = (Rol == "Asesor") ? "AprobacionAsesor" : "AprobacionRevisor";
            var estatus = rbtnAprobar.Checked ? "Aceptado" : "Rechazado";

            DictamenDAO.InsertarDictamen(
                new DictamenPOJO(-1,
                                 idResidencia,
                                 IdDocente,
                                 tipo,
                                 estatus,
                                 txtComentarios.Text,
                                 0,
                                 DateTime.Now));

            Close();
        }
    }
}
