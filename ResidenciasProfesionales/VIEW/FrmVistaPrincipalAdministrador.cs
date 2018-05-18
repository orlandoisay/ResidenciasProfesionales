using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ResidenciasProfesionales.MODEL;
using ResidenciasProfesionales.DATA;

namespace ResidenciasProfesionales.VIEW
{
    public partial class FrmVistaPrincipalAdministrador : Form
    {
        List<DocentePOJO> listaDocentes = new List<DocentePOJO>();

        public FrmVistaPrincipalAdministrador()
        {
            InitializeComponent();
            CentrarLogo();
            llenarCombo();
        }

        public void llenarCombo()
        {
            listaDocentes = DocenteDAO.ObtenerTodosLosDisponibles();
            cbxAsesores.Items.Clear();
            for (int i = 0; i < listaDocentes.Count; i++)
            {
                cbxAsesores.Items.Add(listaDocentes[i].NombreCompleto);
            }
            cbxAsesores.SelectedIndex = 0;
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            CerrarSesion();
        }

        /// <summary>
        /// Cierra la sesión actual en el sistema.
        /// </summary>
        private void CerrarSesion()
        {
            this.Close();
        }

        /// <summary>
        /// Centra el logo en el fondo del formulario.
        /// </summary>
        private void CentrarLogo()
        {
            int left = (Width - pbLogo.Width) / 2;
            int top = (Height - pbLogo.Height) / 2;

            pbLogo.Location = new Point(left, top);
        }

        private void FrmVistaPrincipalAsesor_Resize(object sender, EventArgs e)
        {
            CentrarLogo();
        }

        private void btnReporteResidencia_Click(object sender, EventArgs e)
        {
            var frmReporteResidencia = new FrmReporteResidencias();
            frmReporteResidencia.ShowDialog();
        }

        private void FrmVistaPrincipalAdministrador_Load(object sender, EventArgs e)
        {

        }

        private void btnControlDocumentacion_Click(object sender, EventArgs e)
        {
            panelSeleccion.Visible = true;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            int index = cbxAsesores.SelectedIndex;
            var frmControlDocumentacion = new FrmControlDocumentacion(listaDocentes[index].ID);
            frmControlDocumentacion.ShowDialog();
            panelSeleccion.Visible = false;
        }
    }
}
