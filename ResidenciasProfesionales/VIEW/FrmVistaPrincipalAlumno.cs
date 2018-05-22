using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ResidenciasProfesionales.MODEL;
using ResidenciasProfesionales.DATA;

namespace ResidenciasProfesionales.VIEW
{
    /// <summary>
    /// Vista principal del alumno.
    /// </summary>
    /// <remarks>
    /// Proporciona las opciones que un usuario identificado
    /// como alumno puede realizar.
    /// </remarks>
    public partial class FrmVistaPrincipalAlumno : Form
    {
        // Almacena el identificador del alumno.
        String idAlumno;

        /// <summary>
        /// Inicializa los componentes.
        /// </summary>
        public FrmVistaPrincipalAlumno(String idAlumno)
        {
            InitializeComponent();
            this.idAlumno = idAlumno;
        }

        /// <summary>
        /// Evento capaz de abrir la ventana FrmSolicitud
        /// usando el identificador del alumno ingresado.
        /// </summary>
        private void btnVerSolicitud_Click(object sender, EventArgs e)
        {
            var frmSolicitud = new FrmSolicitud(idAlumno);
            frmSolicitud.ShowDialog();
        }

        /// <summary>
        /// Cierra la ventana actual.
        /// </summary>
        private void pbCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}