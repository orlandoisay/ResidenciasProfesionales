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
    /// <summary>
    /// Permite visualizar tanto los datos del alumno como los
    /// datos del docente seleccionado.
    /// </summary>
    public partial class FrmMostrarDatos : Form
    {
        List<AlumnoPOJO> listaAlumnos = new List<AlumnoPOJO>();
        List<DocentePOJO> listaDocentes = new List<DocentePOJO>();
        String matricula;
        int index;

        /// <summary>
        /// Abre el panel para mostrar los datos del alumno e indica
        /// cual alumno es el seleccionado.
        /// </summary>
        /// <param name="lista"></param>
        /// Contiene todos los alumnos a mostrar.
        /// <param name="inicial"></param>
        /// Indica cual de los alumnos es el que está seleccionado.
        /// <param name="accion"></param>
        /// Indica si se quiere asignar un asesor o cambiarlo.
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
        /// <summary>
        /// Abre el panel para asignar asesor.
        /// </summary>
        /// <param name="matricula"></param>
        /// Identificador del alumno utilizado para hacer la futura 
        /// asignación con el asesor.
        /// <param name="accion"></param>
        /// Indica si se quiere asignar un asesor o cambiarlo.
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

        /// <summary>
        /// Llena el combo box con los docentes disponibles
        /// para ser asesores.
        /// </summary>
        public void abrirAsignacion() {
            panelAsesor.Visible = true;
            panelAsesor.Location = new Point(12, 12);
            listaDocentes = DocenteDAO.ObtenerTodosLosDisponibles();
            cbxAsesor.Items.Clear();
            for (int i = 0; i < listaDocentes.Count; i++)
            {
                cbxAsesor.Items.Add(listaDocentes[i].NombreCompleto);
            }
            cbxAsesor.SelectedIndex = 0;
        }

        /// <summary>
        /// Abre el panel para ver los datos del alumno seleccionado.
        /// </summary>
        private void btnAsignar_Click(object sender, EventArgs e)
        {
            matricula = listaAlumnos[index].Matricula;
            panelAlumno.Visible = false;
            abrirAsignacion();
        }

        /// <summary>
        /// Cierra la ventana actual.
        /// </summary>
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Cierra la ventana actual.
        /// </summary>
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Llena los componentes encargados de mostrar los datos del alumno
        /// seleccionado.
        /// </summary>
        /// <param name="indice"></param>
        /// Funciona como identificador del alumno seleccionado.
        public void llenarDatosAlumno(int indice) {
            lblNoControl.Text = "No. control: " + listaAlumnos[indice].Matricula;
            lblNombre.Text = "Nombre: " + listaAlumnos[indice].NombreCompleto;
            CarreraPOJO carrera = CarreraDAO.ObtenerUno(listaAlumnos[indice].Carrera);
            lblCarreraAlumno.Text = "Carrera: " + carrera.Nombre;
            lblSemestre.Text = "Semestre: " + listaAlumnos[indice].Semestre;
            lblEstatus.Text = "Estatus: " + listaAlumnos[indice].Estatus;
            lblTelefono.Text = "Telefono: " + listaAlumnos[indice].Telefono;
            lblCorreo.Text = "Correo: " + listaAlumnos[indice].Correo;
            lblTipoSS.Text = "Tipo SS: " + listaAlumnos[indice].TipoSS;
            lblNumeroSS.Text = "Número SS: " + listaAlumnos[indice].NumeroSS;
        }

        /// <summary>
        /// Recorre el enfoque del alumno seleccionado al anterior.
        /// </summary>
        private void btnAnterior_Click(object sender, EventArgs e)
        {
            btnSiguiente.Enabled = true;
            index--;
            llenarDatosAlumno(index);
            if (index == 0) {
                btnAnterior.Enabled = false;
            }
        }

        /// <summary>
        /// Recorre el enfoque del alumno seleccionado al siguiente.
        /// </summary>
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

        /// <summary>
        /// Llena los componentes encargados de mostrar los datos del docente
        /// seleccionado.
        /// </summary>
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

        /// <summary>
        /// Revisa si es posible asignar el docente seleccionado al alumno en
        /// cuestion, de ser así se almacena la asignación en la base de datos,
        /// de lo contrario muestra un mensaje sobre el problema.
        /// </summary>
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (listaDocentes[cbxAsesor.SelectedIndex].Estatus == "Inactivo")
            {
                MessageBox.Show("El docente seleccionado está actualmente inactivo\npor lo tanto no puede ser su asesor",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (btnAceptar.Text == "Aceptar") {
                DialogResult dr = MessageBox.Show("Asignar el asesor:\n" + 
                    listaDocentes[cbxAsesor.SelectedIndex].NombreCompleto +
                    "\nal alumno:\n" +
                    AlumnoDAO.ObtenerAlumno(matricula).NombreCompleto, "Info",
                                              MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.No)
                    return;

                DocenteDAO.AsignarAsesorado(matricula, listaDocentes[cbxAsesor.SelectedIndex].ID);
                EntregaDAO.InsertarDocumentosPendientes(matricula);
            }
            else {
                DocentePOJO docenteAnterior = DocenteDAO.ObtenerDocenteXMatricula(matricula);
                if (docenteAnterior.ID == listaDocentes[cbxAsesor.SelectedIndex].ID)
                {
                    MessageBox.Show("El docente seleccionado, actualmente es el asesor del alumno:\n" + 
                        AlumnoDAO.ObtenerAlumno(matricula).NombreCompleto + 
                        "\nsi desea cambiar de asesor, pruebe con otro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DialogResult dr = MessageBox.Show("Asignar el asesor:\n" +
                    listaDocentes[cbxAsesor.SelectedIndex].NombreCompleto +
                    "\nal alumno:\n" +
                    AlumnoDAO.ObtenerAlumno(matricula).NombreCompleto, "Info",
                                              MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.No)
                    return;

                DocenteDAO.CambiarAsesor(listaDocentes[cbxAsesor.SelectedIndex].ID, matricula, docenteAnterior.ID);
                if (docenteAnterior.ID == DocenteDAO.ObtenerDocenteXMatricula(matricula).ID)
                {
                    MessageBox.Show("El docente seleccionado ya cumple un rol con el alumno:\n" + 
                        AlumnoDAO.ObtenerAlumno(matricula).NombreCompleto + "\npor lo tanto no puede ser su asesor", 
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            }
            MessageBox.Show("El docente fue asignado como asesor correctamente", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
