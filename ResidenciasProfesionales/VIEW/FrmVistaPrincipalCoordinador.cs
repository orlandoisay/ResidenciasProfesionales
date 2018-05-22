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
    /// Vista principal del coordinador.
    /// </summary>
    /// <remarks>
    /// Proporciona las opciones que un usuario identificado
    /// como coordinador puede realizar.
    /// </remarks>
    public partial class FrmVistaPrincipalCoordinador : Form
    {
        // Almacena el identificador del coordinador.
        String idDocente;

        /// <summary>
        /// Inicializa los componentes.
        /// </summary>
        public FrmVistaPrincipalCoordinador(String idCoordinador)
        {
            InitializeComponent();
            idDocente = idCoordinador;
        }

        /// <summary>
        /// Evento capaz de abrir la ventana FrmAprobacionSolicitud.
        /// </summary>
        private void btnAprobacionInformes_Click(object sender, EventArgs e)
        {
            var frmAprobarSolicitudes = new FrmAprobacionSolicitud();
            frmAprobarSolicitudes.ShowDialog();
        }

        /// <summary>
        /// Evento capaz de abrir la ventana FrmReporteResidencias.
        /// </summary>
        private void btnReporteResidencias_Click(object sender, EventArgs e)
        {
            var frmReporteResidencia = new FrmReporteResidencias();
            frmReporteResidencia.ShowDialog();
        }

        /// <summary>
        /// Cierra la sesión actual en el sistema.
        /// </summary>
        private void pbCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Cierra la sesión actual en el sistema.
        /// </summary>
        private void lblCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Evento capaz de abrir la ventana FrmMostrarCalificaciones
        /// usando el identificador del coordinador ingresado.
        /// </summary>
        private void btnLiberacionFinal_Click(object sender, EventArgs e)
        {
            var frmLiberacionFin = new FrmLiberacionFinal(idDocente);
            frmLiberacionFin.ShowDialog();
        }

        /// <summary>
        /// Evento capaz de abrir la ventana FrmListaResidentes.
        /// </summary>
        private void btnResidentes_Click(object sender, EventArgs e)
        {
            var frmListaResidentes = new FrmListaResidentes();
            frmListaResidentes.ShowDialog();
        }
    }
}
