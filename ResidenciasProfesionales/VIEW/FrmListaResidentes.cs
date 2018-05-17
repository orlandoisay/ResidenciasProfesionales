using ResidenciasProfesionales.DATA;
using ResidenciasProfesionales.MODEL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ResidenciasProfesionales.VIEW
{
    public partial class FrmListaResidentes : Form
    {

        List<ListaPOJO> lista = new List<ListaPOJO>();

        public FrmListaResidentes()
        {
            InitializeComponent();
        }

        private void cargarDatos() {

        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            List<ResidenciaPOJO> residencias = ResidenciaDAO.ObtenerResidencias();
            for (int i = 0; i < residencias.Count; i++) {
                ListaPOJO elemento = new ListaPOJO();
                elemento.Matricula = residencias[i].IdAlumno;
                elemento.NombreAlumno = AlumnoDAO.ObtenerAlumno(residencias[i].IdAlumno).NombreCompleto;
                elemento.AsesorExt = residencias[i].AsesorExt;
                elemento.Empresa = EmpresaDAO.ObtenerEmpresa(residencias[i].IdEmpresa).Nombre;
                elemento.TelEmpresa = EmpresaDAO.ObtenerEmpresa(residencias[i].IdEmpresa).Telefono;
                elemento.TelAlumno = AlumnoDAO.ObtenerAlumno(residencias[i].IdAlumno).Telefono;
                elemento.CorreoAlumno = AlumnoDAO.ObtenerAlumno(residencias[i].IdAlumno).Correo;

                //TODO Info asesor int
            }
        }
    }
}
