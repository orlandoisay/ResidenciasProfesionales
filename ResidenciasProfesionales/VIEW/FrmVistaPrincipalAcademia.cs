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
    public partial class FrmVistaPrincipalAcademia : Form
    {
        public FrmVistaPrincipalAcademia()
        {
            InitializeComponent();
        }

        private void btnAsignaciónAsesor_Click(object sender, EventArgs e)
        {
            FrmAsignacionAsesor frmAsesor = new FrmAsignacionAsesor();
            frmAsesor.ShowDialog();
        }

        private void btnAsignaciónRevisor_Click(object sender, EventArgs e)
        {
            FrmAsignacionRevisores frmRevisor = new FrmAsignacionRevisores();
            frmRevisor.ShowDialog();
        }
    }
}
