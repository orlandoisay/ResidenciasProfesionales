using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace ResidenciasProfesionales.VIEW
{
    public partial class FrmInicioSesion : Form
    {
        //Para hacer la marca de agua en los textbox
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = false)]
        private static extern IntPtr SendMessage(IntPtr hWind, uint msg, IntPtr i, string str);

        public FrmInicioSesion()
        {
            InitializeComponent();
            //
            cbTipo.SelectedIndex = 0;
            //
            SendMessage(txtUsuario.Handle, 0x1501, (IntPtr)1, "Usuario");
            SendMessage(txtContrasena.Handle, 0x1501, (IntPtr)1, "Contraseña");
            //
            lbContraseña.Visible = false;
            lbUsuario.Visible = false;
            //
          
        }

        private void FrmInicioSesion_Load(object sender, EventArgs e)
        {
        }

        private void hacerLineas() {
            Graphics g = this.CreateGraphics();
            Pen pen = new Pen(Color.Black,2);
            g.DrawLine(pen, 64, 102, 246, 102);
            g.DrawLine(pen, 64, 161, 246, 161);
        }

        private void txtContrasena_TextChanged(object sender, EventArgs e)
        {
            if (txtContrasena.Text.Length == 0)
            {
                lbContraseña.Visible = false;
            }
            else
            {
                lbContraseña.Visible = true;
            }
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            if (txtUsuario.Text.Length == 0)
            {
                lbUsuario.Visible = false;
            }
            else
            {
                lbUsuario.Visible = true;
            }
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
        }

        private void btnEntrar_Paint(object sender, PaintEventArgs e)
        {
            hacerLineas();
        }

        private void cbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
