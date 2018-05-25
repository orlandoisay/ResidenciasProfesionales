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
    /// Clase encargada de asignar asesores a los alumnos.
    /// </summary>
    public partial class FrmAsignacionAsesor : Form
    {
        /// <summary>
        /// Evalua si hay o no alumnos pendientes de asignarles un
        /// asesor, y dependiendo de ello, permitir o limitar las 
        /// opciones proporcionadas.
        /// </summary>
        public FrmAsignacionAsesor()
        {
            InitializeComponent();
            ActualizarTablas();

            if (tablaAsignarAsesor.Rows.Count == 0)
            {
                lblAlumnoAsignar.Text = "NO HAY ALUMNOS A QUIEN ASIGNARLE UN ASESOR";
                tablaAsignarAsesor.Enabled = false;
                enabledBotones("Asignar", false);
            }
            else {
                tablaAsignarAsesor.Rows[0].Selected = true;
                llenarEspaciosAsignarAsesor(0);
                //lblAlumnoAsignar.Text = "SELECCIONE UN ALUMNO";
            }

            if (tablaModificarAsesor.Rows.Count == 0)
            {
                lblAlumnoModificar.Text = "NO HAY ALUMNOS A QUIEN CAMBIARLE EL ASESOR";
                tablaModificarAsesor.Enabled = false;
                enabledBotones("Cambiar", false);
            }
            else
            {
                tablaModificarAsesor.Rows[0].Selected = true;
                llenarEspaciosModificarAsesor(0);
                //lblAlumnoModificar.Text = "SELECCIONE UN ALUMNO";
            }
        }

        /// <summary>
        /// Habilita o deshabilita los botones encargados de
        /// asignar asesores a los alumnos.
        /// </summary>
        public void enabledBotones(String tipo, bool bandera) {
            if (tipo == "Asignar")
            {
                btnAsignar.Enabled = bandera;
                btnMostrarAsignar.Enabled = bandera;
            }
            else {
                btnCambiarAsesor.Enabled = bandera;
                btnMostrarModificar.Enabled = bandera;
            }
        }

        // Listas de alumnos.
        List<AlumnoPOJO> alumnosSinAsesor = new List<AlumnoPOJO>();
        List<AlumnoPOJO> alumnosConAsesor = new List<AlumnoPOJO>();

        /// <summary>
        /// Abre el formulario "FrmMostrarDatos" y establece visible el 
        /// panel referente al asesor.
        /// </summary>
        private void btnAsignar_Click(object sender, EventArgs e)
        {
            int cantidad = tablaAsignarAsesor.Rows.Count;
            new FrmMostrarDatos(matriculaSinAsesor, "Asignar").ShowDialog();
            ActualizarTablas();
            if (tablaAsignarAsesor.Rows.Count == 0) {
                lblAlumnoAsignar.Text = "NO HAY ALUMNOS A QUIEN ASIGNARLE UN ASESOR";
                enabledBotones("Asignar", false);
                tablaAsignarAsesor.Enabled = false;
                tablaModificarAsesor.Enabled = true;
                tablaModificarAsesor.Rows[0].Selected = true;
                llenarEspaciosModificarAsesor(0);
                //lblAlumnoModificar.Text = "SELECCIONE UN ALUMNO";
            }
            else
            if(cantidad != tablaAsignarAsesor.Rows.Count)
            {
                tablaAsignarAsesor.Rows[0].Selected = true;
                llenarEspaciosAsignarAsesor(0);
                //lblAlumnoAsignar.Text = "SELECCIONE UN ALUMNO";
                //enabledBotones("Asignar", false);
                tablaModificarAsesor.Enabled = true;
                tablaModificarAsesor.Rows[0].Selected = true;
                llenarEspaciosModificarAsesor(0);
                //lblAlumnoModificar.Text = "SELECCIONE UN ALUMNO";
            }
        }

        /// <summary>
        /// Abre el formulario "FrmMostrarDatos" y establece visible el 
        /// panel referente al alumno.
        /// </summary>
        private void btnMostrarAsignar_Click(object sender, EventArgs e)
        {
            int cantidad = tablaAsignarAsesor.Rows.Count;
            for (int i = 0; i < alumnosSinAsesor.Count; i++) {
                if (matriculaSinAsesor == alumnosSinAsesor[i].Matricula) {
                    new FrmMostrarDatos(alumnosSinAsesor, i, "Asignar").ShowDialog();
                    break;
                }
            }
            ActualizarTablas();
            if (tablaAsignarAsesor.Rows.Count == 0)
            {
                lblAlumnoAsignar.Text = "NO HAY ALUMNOS A QUIEN ASIGNARLE UN ASESOR";
                enabledBotones("Asignar", false);
                tablaAsignarAsesor.Enabled = false;
                tablaModificarAsesor.Enabled = true;
                tablaModificarAsesor.Rows[0].Selected = true;
                llenarEspaciosModificarAsesor(0);
                //lblAlumnoModificar.Text = "SELECCIONE UN ALUMNO";
            }
            else
            if (cantidad != tablaAsignarAsesor.Rows.Count)
            {
                tablaAsignarAsesor.Rows[0].Selected = true;
                llenarEspaciosAsignarAsesor(0);
                //lblAlumnoAsignar.Text = "SELECCIONE UN ALUMNO";
                //enabledBotones("Asignar", false);
                tablaModificarAsesor.Enabled = true;
                tablaModificarAsesor.Rows[0].Selected = true;
                llenarEspaciosModificarAsesor(0);
                //lblAlumnoModificar.Text = "SELECCIONE UN ALUMNO";
            }
        }

        /// <summary>
        /// Abre el formulario "FrmMostrarDatos" y establece visible el 
        /// panel referente al asesor.
        /// </summary>
        private void btnCambiarAsesor_Click(object sender, EventArgs e)
        {
            new FrmMostrarDatos(matriculaConAsesor, "Cambiar").ShowDialog();
            ActualizarTablas();
        }

        /// <summary>
        /// Abre el formulario "FrmMostrarDatos" y establece visible el 
        /// panel referente al alumno.
        /// </summary>
        private void btnMostrarModificar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < alumnosConAsesor.Count; i++)
            {
                if (matriculaConAsesor == alumnosConAsesor[i].Matricula)
                {
                    new FrmMostrarDatos(alumnosConAsesor, i, "Cambiar").ShowDialog();
                    break;
                }
            }
            ActualizarTablas();
        }

        /// <summary>
        /// Actualiza las tablas después de cada modificación.
        /// </summary>
        public void ActualizarTablas() {
            tablaAsignarAsesor.Rows.Clear();
            tablaModificarAsesor.Rows.Clear();
            // Lista donde se guardaran todos los alumnos sin y con asesor.
            alumnosSinAsesor = AlumnoDAO.ObtenerAlumnosSinAsesorSolicitudAprobada();
            alumnosConAsesor = AlumnoDAO.ObtenerAlumnosConAsesorSinLiberarResidencias();
            DocentePOJO asesor;
            // Ciclo para llenar la tabla.
            for (int i = 0; i < alumnosSinAsesor.Count; i++) {
                tablaAsignarAsesor.Rows.Add(alumnosSinAsesor[i].Matricula, alumnosSinAsesor[i].NombreCompleto);
            }
            for (int i = 0; i < alumnosConAsesor.Count; i++)
            {
                asesor = DocenteDAO.ObtenerDocenteXMatricula(alumnosConAsesor[i].Matricula);
                tablaModificarAsesor.Rows.Add(alumnosConAsesor[i].Matricula, alumnosConAsesor[i].NombreCompleto, asesor.NombreCompleto);
            }
    }


        private void tablaAsignarAsesor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        // Variables para almacenar el identificador.
        String matriculaSinAsesor;
        String matriculaConAsesor;

        /// <summary>
        /// Evento capaz de reconocer la fila seleccionada.
        /// </summary>
        private void tablaAsignarAsesor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                tablaAsignarAsesor.Rows[e.RowIndex].Selected = true;
                enabledBotones("Asignar", true);
                matriculaSinAsesor = tablaAsignarAsesor.Rows[e.RowIndex].Cells["noControlAsignar"].Value.ToString();
                String nombreSeleccionado = tablaAsignarAsesor.Rows[e.RowIndex].Cells["nombreAsignar"].Value.ToString();
                lblAlumnoAsignar.Text = "ALUMNO: " + nombreSeleccionado.ToUpper();
            }
            catch (Exception)
            {
            }
        }

        public void llenarEspaciosAsignarAsesor(int index)
        {
            tablaAsignarAsesor.Rows[index].Selected = true;
            enabledBotones("Asignar", true);
            matriculaSinAsesor = tablaAsignarAsesor.Rows[index].Cells["noControlAsignar"].Value.ToString();
            String nombreSeleccionado = tablaAsignarAsesor.Rows[index].Cells["nombreAsignar"].Value.ToString();
            lblAlumnoAsignar.Text = "ALUMNO: " + nombreSeleccionado.ToUpper();
        }

        /// <summary>
        /// Evento capaz de reconocer la fila seleccionada.
        /// </summary>
        private void tablaModificarAsesor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                tablaModificarAsesor.Rows[e.RowIndex].Selected = true;
                enabledBotones("Cambiar", true);
                matriculaConAsesor = tablaModificarAsesor.Rows[e.RowIndex].Cells["noControlModificar"].Value.ToString();
                String nombreSeleccionado = tablaModificarAsesor.Rows[e.RowIndex].Cells["nombreModificar"].Value.ToString();
                lblAlumnoModificar.Text = "ALUMNO: " + nombreSeleccionado.ToUpper();
            }
            catch (Exception)
            {
            }
            
        }

        public void llenarEspaciosModificarAsesor(int index)
        {
            tablaModificarAsesor.Rows[index].Selected = true;
            enabledBotones("Cambiar", true);
            matriculaConAsesor = tablaModificarAsesor.Rows[index].Cells["noControlModificar"].Value.ToString();
            String nombreSeleccionado = tablaModificarAsesor.Rows[index].Cells["nombreModificar"].Value.ToString();
            lblAlumnoModificar.Text = "ALUMNO: " + nombreSeleccionado.ToUpper();
        }

    }
}