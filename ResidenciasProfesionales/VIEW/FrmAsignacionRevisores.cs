﻿using System;
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

        private void pPanelV2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            //
            pPanel.Visible = false;
            pPanelV2.Location = new Point(pPanel.Location.X, pPanel.Location.Y);
            pPanelV2.Size = new Size(939, 477);
            pPanelV2.Visible = true;
        }
    }
}
