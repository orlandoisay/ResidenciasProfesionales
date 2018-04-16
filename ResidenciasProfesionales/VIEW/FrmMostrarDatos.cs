using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ResidenciasProfesionales.MODEL;
using ResidenciasProfesionales.DATA;

namespace ResidenciasProfesionales.VIEW
{
    public partial class FrmMostrarDatos : Form
    {
        List<AlumnoPOJO> listaAlumnos = new List<AlumnoPOJO>();
        List<DocentePOJO> listaDocentes = new List<DocentePOJO>();
        String matricula;
        int index;

        public FrmMostrarDatos(List<AlumnoPOJO> lista, int inicial, String accion)
        {
            InitializeComponent();

            this.Size = new Size(550, 270);
            if (accion == "Cambiar")
            {
                btnAceptar.Text = "Cambiar Asesor";
            }
            panelAlumno.Visible = true;
                    listaAlumnos = lista;
                    if (inicial == 0) {
                        btnAnterior.Enabled = false;
                    }
                    if (inicial == listaAlumnos.Count-1) {
                        btnSiguiente.Enabled = false;
                    }
                    index = inicial;
                    llenarDatosAlumno(index);
            
        }
        // Abre el panel para asignar asesor, solo recibe como parámetros la matricula del alumno
        // para hacer la futura asignación con el asesor.
        public FrmMostrarDatos(String matricula, String accion)
        {
            InitializeComponent();
            this.Size = new Size(550, 270);

            if (accion == "Cambiar") {
                btnAceptar.Text = "Cambiar Asesor";
            }
            this.matricula = matricula;
            abrirAsignacion();
        }

        public void abrirAsignacion() {
            panelAsesor.Visible = true;
            panelAsesor.Location = new Point(12, 12);
            listaDocentes = DocenteDAO.ObtenerTodos();
            cbxAsesor.Items.Clear();
            for (int i = 0; i < listaDocentes.Count; i++)
            {
                cbxAsesor.Items.Add(listaDocentes[i].NombreCompleto);
            }
        }

        private void btnAsignar_Click(object sender, EventArgs e)
        {
            matricula = listaAlumnos[index].Matricula;
            panelAlumno.Visible = false;
            abrirAsignacion();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void llenarDatosAlumno(int indice) {
            lblNoControl.Text = "No. control: " + listaAlumnos[indice].Matricula;
            lblNombre.Text = "Nombre: " + listaAlumnos[indice].Nombre;
            CarreraPOJO carrera = CarreraDAO.ObtenerUno(listaAlumnos[indice].Carrera);
            lblCarreraAlumno.Text = "Carrera: " + carrera.Nombre;
            lblEstatus.Text = "Estatus: " + listaAlumnos[indice].Estatus;
            lblTelefono.Text = "Telefono: " + listaAlumnos[indice].Telefono;
            lblCorreo.Text = "Correo: " + listaAlumnos[indice].Correo;
            lblTipoSS.Text = "Tipo SS: " + listaAlumnos[indice].TipoSS;
            lblNumeroSS.Text = "Número SS: " + listaAlumnos[indice].NumeroSS;
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            btnSiguiente.Enabled = true;
            index--;
            llenarDatosAlumno(index);
            if (index == 0) {
                btnAnterior.Enabled = false;
            }
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            btnAnterior.Enabled = true;
            index++;
            llenarDatosAlumno(index);
            if (index == listaAlumnos.Count-1)
            {
                btnSiguiente.Enabled = false;
            }
        }

        private void cbxAsesor_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice = cbxAsesor.SelectedIndex;
            CarreraPOJO carrera = CarreraDAO.ObtenerUno(listaDocentes[indice].Carrera);
            lblCarreraAsesor.Text = "Carrera : " + carrera.Nombre;
            lblEstatusAsesor.Text = "Estatus: " + listaDocentes[indice].Estatus;
            lblNumeroAsesorados.Text = "Asesorados a su cargo: " + DocenteDAO.ObtenerCantidadAsesorados(listaDocentes[indice].ID);
            lblTelefonoAsesor.Text = "Telefono: " + listaDocentes[indice].Telefono;
            lblCorreoAsesor.Text = "Correo: " + listaDocentes[indice].Correo;
            lblUsuario.Text = "Usuario: " + listaDocentes[indice].Usuario;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (btnAceptar.Text == "Aceptar") {
                DocenteDAO.AsignarAsesorado(matricula, listaDocentes[cbxAsesor.SelectedIndex].ID);
            }
            else {
                DocentePOJO docenteAnterior = DocenteDAO.ObtenerDocenteXMatricula(matricula);
                DocenteDAO.CambiarAsesor(listaDocentes[cbxAsesor.SelectedIndex].ID, matricula, docenteAnterior.ID);
            }
            EntregaDAO.InsertarDocumentosPendientes(matricula);
            MessageBox.Show("Asignado");
            this.Close();
        }
    }
}
