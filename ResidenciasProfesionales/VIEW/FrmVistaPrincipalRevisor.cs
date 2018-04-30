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
    public partial class FrmVistaPrincipalRevisor : Form
    {
        private String IdDocente;

        /// <summary>
        /// Crea una instancia de un formulario de vista principal para un
        /// usuario con el rol de revisor.
        /// </summary>
        /// <param name="IdDocente">El Id del revisor</param>
        public FrmVistaPrincipalRevisor(String IdDocente)
        {
            InitializeComponent();
            this.IdDocente = IdDocente;
            CentrarLogo();
        }

        private void btnAprobacion_Click(object sender, EventArgs e)
        {
            var frmAprobacionInformeLista = new FrmAprobacionInformeLista(IdDocente, "Revisor");
            frmAprobacionInformeLista.ShowDialog();
        }
        private void btnLiberacion_Click(object sender, EventArgs e)
        {
            var frmLiberacionInformeLista = new FrmLiberacionInformeLista(IdDocente, "Revisor");
            frmLiberacionInformeLista.ShowDialog();
        }
        private void pnlCerrarSesion_Click(object sender, EventArgs e)
        {
            CerrarSesion();
        }
        private void FrmVistaPrincipalRevisor_Resize(object sender, EventArgs e)
        {
            CentrarLogo();
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
        /// <summary>
        /// Cierra la sesión actual en el sistema.
        /// </summary>
        private void CerrarSesion()
        {
            this.Close();
        }
    }
}
