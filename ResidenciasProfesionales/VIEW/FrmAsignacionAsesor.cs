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
    public partial class FrmAsignacionAsesor : Form
    {
        public FrmAsignacionAsesor()
        {
            InitializeComponent();
        }

        private void btnAsignar_Click(object sender, EventArgs e)
        {
            new FrmMostrarDatos("Asesor").ShowDialog();
        }

        private void btnMostrarAsignar_Click(object sender, EventArgs e)
        {
            new FrmMostrarDatos("Alumno").ShowDialog();
        }

        private void btnCambiarAsesor_Click(object sender, EventArgs e)
        {
            new FrmMostrarDatos("Asesor").ShowDialog();
        }

        private void btnMostrarModificar_Click(object sender, EventArgs e)
        {
            new FrmMostrarDatos("Alumno").ShowDialog();
        }
    }
}
