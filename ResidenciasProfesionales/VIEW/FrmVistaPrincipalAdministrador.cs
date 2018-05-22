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
    /// <summary>
    /// Vista principal del administrador.
    /// </summary>
    /// <remarks>
    /// Proporciona las opciones que un usuario identificado
    /// como administrador puede realizar.
    /// </remarks>
    public partial class FrmVistaPrincipalAdministrador : Form
    {
        List<DocentePOJO> listaDocentes = new List<DocentePOJO>();

        /// <summary>
        /// Inicializa los componentes.
        /// </summary>
        public FrmVistaPrincipalAdministrador()
        {
            InitializeComponent();
            CentrarLogo();
            llenarCombo();
        }

        /// <summary>
        /// Llena el combo box con los asesores disponibles.
        /// </summary>
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

        /// <summary>
        /// Evento capaz de abrir la ventana FrmReporteResidencias.
        /// </summary>
        private void btnReporteResidencia_Click(object sender, EventArgs e)
        {
            var frmReporteResidencia = new FrmReporteResidencias();
            frmReporteResidencia.ShowDialog();
            panelSeleccion.Visible = false;
        }

        private void FrmVistaPrincipalAdministrador_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Permite visualizar el panel encargado de desplegar más 
        /// opciones sobre el control de documentación.
        /// </summary>
        private void btnControlDocumentacion_Click(object sender, EventArgs e)
        {
            panelSeleccion.Visible = true;
        }

        /// <summary>
        /// Evento capaz de abrir la ventana FrmControlDocumentacion
        /// usando el identificador del docente seleccionado.
        /// </summary>
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            int index = cbxAsesores.SelectedIndex;
            var frmControlDocumentacion = new FrmControlDocumentacion(listaDocentes[index].ID);
            frmControlDocumentacion.ShowDialog();
            panelSeleccion.Visible = false;
        }

        /// <summary>
        /// Evento capaz de abrir la ventana FrmMostrarCalificaciones
        /// usando el identificador del docente seleccionado.
        /// </summary>
        private void btnVer_Click(object sender, EventArgs e)
        {
            int index = cbxAsesores.SelectedIndex;
            var frmMostrarCalificacion = new FrmMostrarCalificaciones(listaDocentes[index].ID);
            frmMostrarCalificacion.ShowDialog();
            panelSeleccion.Visible = false;
        }
    }
}
