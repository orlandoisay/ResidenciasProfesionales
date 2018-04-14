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
        private int IdDocente;
        private string Matricula;
        private DictamenPOJO Dictamen;

        public FrmAprobacionInforme(int idDocente, string matricula)
        {
            IdDocente = idDocente;
            Matricula = matricula;
            //Dictamen = DictamenDAO.ObtenerDictamen(idDocente, matricula);
            InitializeComponent();
            CargarDatosAlumno();

            if(Dictamen == null)
                CargarDatosDictamen();
            
        }

        private void btnEvaluar_Click(object sender, EventArgs e)
        {

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

            // TODO : Mostrar contenido del dictamen
        }
    }
}
