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
            var frmAprobarInforme = new FrmSolicitud(idDocente);
            frmAprobarInforme.ShowDialog();
        }

        private void btnReporteResidencias_Click(object sender, EventArgs e)
        {
            var frmReporteResidencia = new FrmReporteResidencias();
            frmReporteResidencia.ShowDialog();
        }
    }
}
