using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ResidenciasProfesionales.VIEW
{
    public partial class FrmVistaPrincipalAdministrador : Form
    {
        public FrmVistaPrincipalAdministrador()
        {
            InitializeComponent();
            CentrarLogo();
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

        }
    }
}
