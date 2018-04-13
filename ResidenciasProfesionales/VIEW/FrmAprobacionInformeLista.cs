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
    public partial class FrmAprobacionInformeLista : Form
    {
        private int IdDocente;

        public FrmAprobacionInformeLista(int idDocente)
        {
            IdDocente = idDocente;
            InitializeComponent();            
            CargarInformes();
        }        

        private void btnEvaluar_Click(object sender, EventArgs e)
        {
            if(dgvLista.SelectedRows.Count == 0)
            {
                MessageBox.Show("Debe seleccionar un registro.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var matricula = dgvLista.SelectedRows[0].Cells[0].Value.ToString();
            var frmAprobacionInforme = new FrmAprobacionInforme(IdDocente, matricula);
            frmAprobacionInforme.ShowDialog();
            CargarInformes();
        }

        private void CargarInformes()
        {
            var listaInformes = InformeDAO.ObtenerInformesPorPeriodo(Properties.Settings.Default.Anio,
                                                                     Properties.Settings.Default.Periodo,
                                                                     IdDocente,
                                                                     false);
            dgvLista.DataSource = listaInformes;
        }
    }
}
