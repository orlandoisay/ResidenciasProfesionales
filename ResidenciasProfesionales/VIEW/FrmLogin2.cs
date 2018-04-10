using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using ResidenciasProfesionales.MODEL;
using ResidenciasProfesionales.DATA;

namespace ResidenciasProfesionales.VIEW
{
    public partial class FrmLogin2 : Form
    {
        //Para hacer la marca de agua en los textbox
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = false)]
        private static extern IntPtr SendMessage(IntPtr hWind, uint msg, IntPtr i, string str);


        public FrmLogin2()
        {
            InitializeComponent();
            //
            cbTipo.SelectedIndex = 0;
            //
            SendMessage(tbUsuario.Handle, 0x1501, (IntPtr)1, "Usuario");
            SendMessage(tbContrasena.Handle, 0x1501, (IntPtr)1, "Contraseña");
            //
            lbContrasena.Visible = false;
            lbUsuario.Visible = false;
            //
            this.pPanel.BackColor = Color.FromArgb(39, 174, 96);
            this.lbUsuario.ForeColor = Color.FromArgb(127, 140, 141);
            this.lbContrasena.ForeColor = Color.FromArgb(127, 140, 141);

        }

        private void hacerLineas()
        {
            Graphics g = this.CreateGraphics();
            Pen pen = new Pen(Color.FromArgb(189, 195, 199));
            g.DrawLine(pen, 38, 128, 236, 128);
            g.DrawLine(pen, 38, 182, 236, 182);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tbUsuario.Text != "" || tbContrasena.Text != "")
            {
                Usuario u = new Usuario(tbUsuario.Text, tbContrasena.Text, cbTipo.Text);
                UsuarioDao ud = new UsuarioDao();
                if (ud.Existe(u))
                {
                    MessageBox.Show("Bien-Mientras pongo la ventan principal");
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos");
                }
            }
            else
            {
                MessageBox.Show("Llena todos los campos");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (tbUsuario.Text.Length == 0)
            {
                lbUsuario.Visible = false;
            }
            else
            {
                lbUsuario.Visible = true;
            }
        }

        private void tbContrasena_TextChanged(object sender, EventArgs e)
        {
            if (tbContrasena.Text.Length == 0)
            {
                lbContrasena.Visible = false;
            }
            else
            {
                lbContrasena.Visible = true;
            }
        }

        private void FrmLogin2_Paint(object sender, PaintEventArgs e)
        {
            hacerLineas();
        }

        private void FrmLogin2_Load(object sender, EventArgs e)
        {

        }
    }
}
