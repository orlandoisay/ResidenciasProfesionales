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
    public partial class FrmMostrarDatos : Form
    {
        public FrmMostrarDatos(String tipo)
        {
            InitializeComponent();

            this.Size = new Size(550, 270);
            switch (tipo)
            {
                case "Alumno":
                    panelAlumno.Visible = true;
                    break;
                case "Asesor":
                    panelAsesor.Visible = true;
                    panelAsesor.Location = new Point(12, 12);
                    break;
            }
        }

        private void btnAsignar_Click(object sender, EventArgs e)
        {
            panelAlumno.Visible = false;
            panelAsesor.Visible = true;
            panelAsesor.Location = new Point(12, 12);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
