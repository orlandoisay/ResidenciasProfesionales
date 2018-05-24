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
    /// <summary>
    /// Login de la aplicación.
    /// </summary>
    /// <remarks>
    /// Restringe el acceso a la aplicación.
    /// </remarks>
    public partial class FrmLogin2 : Form
    {
        //Instrucciones para producir la marca de agua en los textboxs.
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = false)]
        private static extern IntPtr SendMessage(IntPtr hWind, uint msg, IntPtr i, string str);
       
        // Almacena al docente ingresado.
        DocentePOJO docenteIngresado;

        /// <summary>
        /// Prepara la presentación del login en pantalla.
        /// </summary>
        public FrmLogin2()
        {
            InitializeComponent();
            cbTipo.SelectedIndex = 0;
            SendMessage(tbUsuario.Handle, 0x1501, (IntPtr)1, "Usuario");
            SendMessage(tbContrasena.Handle, 0x1501, (IntPtr)1, "Contraseña");
            lbContrasena.Visible = false;
            lbUsuario.Visible = false;
            this.pPanel.BackColor = Color.FromArgb(39, 174, 96);
            this.lbUsuario.ForeColor = Color.FromArgb(127, 140, 141);
            this.lbContrasena.ForeColor = Color.FromArgb(127, 140, 141);
        }

        /// <summary>
        /// Produce efectos visuales.
        /// </summary>
        private void hacerLineas()
        {
            Graphics g = this.CreateGraphics();
            Pen pen = new Pen(Color.FromArgb(189, 195, 199));
            g.DrawLine(pen, 38, 128, 236, 128);
            g.DrawLine(pen, 38, 182, 236, 182);
        }

        /// <summary>
        /// Limpia los campos editables del login.
        /// </summary>
        private void limpiarCampos()
        {
            tbUsuario.Text = "";
            tbContrasena.Text = "";
        }

        /// <summary>
        /// Evento capaz de reconocer como validos, los datos ingresados 
        /// a través del login y con base en ellos dirigir al usuario
        /// a su respectiva ventana principal.
        /// </summary>
        private void button1_Click(object sender, EventArgs e)
        {
            if (tbUsuario.Text != "" || tbContrasena.Text != "")
            {
                Usuario u = new Usuario(tbUsuario.Text, tbContrasena.Text, cbTipo.Text);
                UsuarioDao ud = new UsuarioDao();
                if (ud.Existe(u))
                {
                        switch (cbTipo.Text) {
                        case "Asesor":
                            docenteIngresado = DocenteDAO.ObtenerDocenteXUsuario(tbUsuario.Text);
                            this.Visible = false;
                            FrmVistaPrincipalAsesor fvpa = new FrmVistaPrincipalAsesor(docenteIngresado.ID);
                            fvpa.ShowDialog();
                            this.Visible = true;
                            limpiarCampos();
                            break;
                        case "Revisor":
                            docenteIngresado = DocenteDAO.ObtenerDocenteXUsuario(tbUsuario.Text);
                            this.Visible = false;
                            FrmVistaPrincipalRevisor fvpr = new FrmVistaPrincipalRevisor(docenteIngresado.ID);
                            fvpr.ShowDialog();
                            this.Visible = true;
                            limpiarCampos();
                            break;
                        case "Alumno":
                            this.Visible = false;
                            FrmVistaPrincipalAlumno fvp_a = new FrmVistaPrincipalAlumno(tbUsuario.Text);
                            fvp_a.ShowDialog();
                            this.Visible = true;
                            limpiarCampos();
                            break;
                        case "Academia":
                            this.Visible = false;
                            FrmVistaPrincipalAcademia fvpac = new FrmVistaPrincipalAcademia();
                            fvpac.ShowDialog();
                            this.Visible = true;
                            limpiarCampos();
                            break;
                        case "Coordinador":
                            docenteIngresado = DocenteDAO.ObtenerDocenteXUsuario(tbUsuario.Text);
                            this.Visible = false;
                            FrmVistaPrincipalCoordinador fvpc = new FrmVistaPrincipalCoordinador(docenteIngresado.ID);
                            fvpc.ShowDialog();
                            this.Visible = true;
                            limpiarCampos();
                            break;
                        case "Administrador":
                            this.Visible = false;
                            FrmVistaPrincipalAdministrador fvoa = new FrmVistaPrincipalAdministrador();
                            fvoa.ShowDialog();
                            this.Visible = true;
                            limpiarCampos();
                            break;
                    }
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1);
                }
            }
            else
            {
                MessageBox.Show("Llena todos los campos.",
                "Aviso",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1);
            }
        }

        /// <summary>
        /// Produce efectos visuales en el momento en que se escribe.
        /// </summary>
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

        /// <summary>
        /// Produce efectos visuales en el momento en que se escribe.
        /// </summary>
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

        /// <summary>
        /// Produce efectos visuales.
        /// </summary>
        private void FrmLogin2_Paint(object sender, PaintEventArgs e)
        {
            hacerLineas();
        }

        private void FrmLogin2_Load(object sender, EventArgs e)
        {

        }
    }
}
