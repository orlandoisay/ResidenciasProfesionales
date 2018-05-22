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
    /// <summary>
    /// Vista principal del revisor.
    /// </summary>
    /// <remarks>
    /// Proporciona las opciones que un usuario identificado
    /// como revisor puede realizar.
    /// </remarks>
    public partial class FrmVistaPrincipalRevisor : Form
    {
        private String IdDocente;

        /// <summary>
        /// Crea una instancia de un formulario de vista principal para un
        /// usuario con el rol de revisor.
        /// </summary>
        /// <param name="IdDocente">El Id del revisor</param>
        /// Identificador del docente.
        public FrmVistaPrincipalRevisor(String IdDocente)
        {
            InitializeComponent();
            this.IdDocente = IdDocente;
            CentrarLogo();
        }

        /// <summary>
        /// Evento capaz de abrir la ventana FrmAprobacionInformeLista
        /// usando el identificador del revisor ingresado.
        /// </summary>
        private void btnAprobacion_Click(object sender, EventArgs e)
        {
            var frmAprobacionInformeLista = new FrmAprobacionInformeLista(IdDocente, "Revisor");
            frmAprobacionInformeLista.ShowDialog();
        }

        /// <summary>
        /// Evento capaz de abrir la ventana FrmLiberacionInformeLista
        /// usando el identificador del revisor ingresado.
        /// </summary>
        private void btnLiberacion_Click(object sender, EventArgs e)
        {
            var frmLiberacionInformeLista = new FrmLiberacionInformeLista(IdDocente, "Revisor");
            frmLiberacionInformeLista.ShowDialog();
        }

        /// <summary>
        /// Cierra la ventana actual.
        /// </summary>
        private void pnlCerrarSesion_Click(object sender, EventArgs e)
        {
            CerrarSesion();
        }

        /// <summary>
        /// Cierra la ventana actual.
        /// </summary>
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

        /// <summary>
        /// Evento capaz de abrir la ventana FrmListaPreLiberacion.
        /// </summary>
        private void btnPreLiberacion_Click(object sender, EventArgs e)
        {
            var frmPreLiberacion = new FrmListaPreLiberacion();
            frmPreLiberacion.ShowDialog();
        }
    }
}
