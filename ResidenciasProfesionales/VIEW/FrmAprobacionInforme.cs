using ResidenciasProfesionales.DATA;
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

        public FrmAprobacionInforme(int idDocente, string matricula)
        {
            IdDocente = idDocente;
            Matricula = matricula;
            InitializeComponent();
            CargarDatosAlumno();
        }

        private void btnEvaluar_Click(object sender, EventArgs e)
        {

        }

        private void CargarDatosAlumno()
        {
            var alumno = new AlumnoDAO().ObtenerAlumno(Matricula);

            txtNoControl.Text = alumno.Matricula;
            txtNombre.Text = string.Format("{0} {1}, {2}", alumno.ApellidoP, alumno.ApellidoM, alumno.Nombre);
            txtCarrera.Text = CarreraDAO.ObtenerUno(alumno.Carrera).Nombre;
            txtSemestre.Text = alumno.Semestre.ToString();
        }
    }
}
