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
    public partial class FrmVistaPrincipalCoordinador : Form
    {
        String idDocente;
        public FrmVistaPrincipalCoordinador(String idCoordinador)
        {
            InitializeComponent();
            idDocente = idCoordinador;
        }

        private void btnAprobacionInformes_Click(object sender, EventArgs e)
        {
            var frmAprobarSolicitudes = new FrmAprobacionSolicitud();
            frmAprobarSolicitudes.ShowDialog();
        }

        private void btnReporteResidencias_Click(object sender, EventArgs e)
        {
            var frmReporteResidencia = new FrmReporteResidencias();
            frmReporteResidencia.ShowDialog();
        }

        private void pbCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
