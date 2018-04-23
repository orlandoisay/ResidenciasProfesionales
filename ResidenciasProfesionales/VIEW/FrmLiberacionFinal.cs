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
    public partial class FrmLiberacionFinal : Form
    {
        DocentePOJO doce = new DocentePOJO();
        public FrmLiberacionFinal(String idDocente)
        {
            InitializeComponent();
            doce = DocenteDAO.ObtenerDocente(idDocente);
            cargarDatos();
        }

        private void btnLiberar_Click(object sender, EventArgs e)
        {
            ResidenciaPOJO res = ResidenciaDAO.ObtenerResidenciaXMatricula(dgvLista.CurrentRow.Cells[0].Value.ToString());
            FrmLiberacionFinalDetalle frmMostrar = new FrmLiberacionFinalDetalle(res,doce.ID);
            frmMostrar.FormClosed += new FormClosedEventHandler(cargarDatos);
            frmMostrar.Show();
        }

        private void cargarDatos(object sender, FormClosedEventArgs e)
        {
            List<ResidenciaPOJO> residencias = ResidenciaDAO.ObtenerResidenciaLiberacion();
            List<LiberacionFinalPOJO> liberacionesPendientes = new List<LiberacionFinalPOJO>();

            for (int i = 0; i < residencias.Count; i++) {
                AlumnoPOJO al = AlumnoDAO.ObtenerAlumno(residencias[i].IdAlumno);
                EmpresaPOJO emp = EmpresaDAO.ObtenerEmpresa(residencias[i].IdEmpresa);
                liberacionesPendientes.Add(new LiberacionFinalPOJO(al.Matricula,al.NombreCompleto,
                    residencias[i].NombreProyec,emp.Nombre, residencias[i].IdEmpresa));
            }

            dgvLista.DataSource = null;
            dgvLista.DataSource = liberacionesPendientes;
        }

        private void cargarDatos() {
            List<ResidenciaPOJO> residencias = ResidenciaDAO.ObtenerResidenciaLiberacion();
            List<LiberacionFinalPOJO> liberacionesPendientes = new List<LiberacionFinalPOJO>();

            for (int i = 0; i < residencias.Count; i++)
            {
                AlumnoPOJO al = AlumnoDAO.ObtenerAlumno(residencias[i].IdAlumno);
                EmpresaPOJO emp = EmpresaDAO.ObtenerEmpresa(residencias[i].IdEmpresa);
                liberacionesPendientes.Add(new LiberacionFinalPOJO(al.Matricula, al.NombreCompleto,
                    residencias[i].NombreProyec, emp.Nombre, residencias[i].IdEmpresa));
            }

            dgvLista.DataSource = null;
            dgvLista.DataSource = liberacionesPendientes;
        }
    }
}
