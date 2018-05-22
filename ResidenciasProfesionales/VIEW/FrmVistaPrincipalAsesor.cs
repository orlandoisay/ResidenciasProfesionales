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
    /// <summary>
    /// Vista principal del asesor.
    /// </summary>
    /// <remarks>
    /// Proporciona las opciones que un usuario identificado
    /// como asesor puede realizar.
    /// </remarks>
    public partial class FrmVistaPrincipalAsesor : Form
    {
        // Almacena el identificador del docente.
        private String IdDocente;

        /// <summary>
        /// Inicializa los componentes.
        /// </summary>
        public FrmVistaPrincipalAsesor(String IdDocente)
        {
            InitializeComponent();
            this.IdDocente = IdDocente;
            CentrarLogo();
        }

        /// <summary>
        /// Evento capaz de abrir la ventana FrmAprobacionInformeLista
        /// usando el identificador del docente ingresado.
        /// </summary>
        private void btnAprobacionInformes_Click(object sender, EventArgs e)
        {
            var frmAprobacionInformeLista = new FrmAprobacionInformeLista(IdDocente, "Asesor");
            frmAprobacionInformeLista.ShowDialog();
        }

        /// <summary>
        /// Evento capaz de abrir la ventana FrmLiberacionInformeLista
        /// usando el identificador del docente ingresado.
        /// </summary>
        private void btnLiberacionInformes_Click(object sender, EventArgs e)
        {
            var frmLiberacionInformeLista = new FrmLiberacionInformeLista(IdDocente, "Asesor");
            frmLiberacionInformeLista.ShowDialog();
        }

        /// <summary>
        /// Evento capaz de abrir la ventana FrmControlDocumentacion
        /// usando el identificador del docente ingresado.
        /// </summary>
        private void btnControlDocumentacion_Click(object sender, EventArgs e)
        {
            var frmControlDocumentacion = new FrmControlDocumentacion(IdDocente);
            frmControlDocumentacion.ShowDialog();
        }

        /// <summary>
        /// Cierra la ventana actual.
        /// </summary>
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

        /// <summary>
        /// Centra el logo de la institución en la interfaz.
        /// </summary>
        private void FrmVistaPrincipalAsesor_Resize(object sender, EventArgs e)
        {
            CentrarLogo();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
