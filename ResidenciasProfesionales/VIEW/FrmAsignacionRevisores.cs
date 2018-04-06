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
    public partial class FrmAsignacionRevisores : Form
    {
        public FrmAsignacionRevisores()
        {
            InitializeComponent();
            this.Size = new Size(958, 518);
            //939, 477
            pPanel.Size = new Size(939, 477);
            pPanelV2.Visible = false;
        }

        private void pPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
