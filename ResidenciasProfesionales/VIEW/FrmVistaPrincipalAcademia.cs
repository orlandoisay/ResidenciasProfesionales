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
    /// Vista principal de la academia.
    /// </summary>
    /// <remarks>
    /// Proporciona las opciones que un usuario identificado
    /// como academia puede realizar.
    /// </remarks>
    public partial class FrmVistaPrincipalAcademia : Form
    {
        public FrmVistaPrincipalAcademia()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Evento capaz de abrir la ventana FrmAsignacionAsesor.
        /// </summary>
        private void btnAsignaciónAsesor_Click(object sender, EventArgs e)
        {
            FrmAsignacionAsesor frmAsesor = new FrmAsignacionAsesor();
            frmAsesor.ShowDialog();
        }

        /// <summary>
        /// Evento capaz de abrir la ventana FrmAsignacionRevisores.
        /// </summary>
        private void btnAsignaciónRevisor_Click(object sender, EventArgs e)
        {
            FrmAsignacionRevisores frmRevisor = new FrmAsignacionRevisores();
            frmRevisor.ShowDialog();
        }

        /// <summary>
        /// Cierra la ventana actual.
        /// </summary>
        private void pbCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Evento capaz de abrir la ventana FrmListaResidentes.
        /// </summary>
        private void btnResidentes_Click(object sender, EventArgs e)
        {
            var frmResidentes = new FrmListaResidentes();
            frmResidentes.ShowDialog();
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