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
    public partial class FrmAsignacionAsesor : Form
    {
        public FrmAsignacionAsesor()
        {
            InitializeComponent();
            ActualizarTablas();
            // Establece los botones deshabilitados hasta que seleccione un registro de la lista.

            if (tablaAsignarAsesor.Rows.Count == 0)
            {
                lblAlumnoAsignar.Text = "NO HAY ALUMNOS A QUIEN ASIGNARLE UN ASESOR";
                tablaAsignarAsesor.Enabled = false;
            }
            else {
                lblAlumnoAsignar.Text = "SELECCIONE UN ALUMNO";
            }

            if (tablaModificarAsesor.Rows.Count == 0)
            {
                lblAlumnoModificar.Text = "NO HAY ALUMNOS A QUIEN CAMBIARLE EL ASESOR";
                tablaModificarAsesor.Enabled = false;
            }
            else
            {
                lblAlumnoModificar.Text = "SELECCIONE UN ALUMNO";
            }
            
            enabledBotones("Asignar", false);
            enabledBotones("Cambiar", false);
        }

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

        List<AlumnoPOJO> alumnosSinAsesor = new List<AlumnoPOJO>();
        List<AlumnoPOJO> alumnosConAsesor = new List<AlumnoPOJO>();

        private void btnAsignar_Click(object sender, EventArgs e)
        {
            // Abre el formulario "FrmMostrarDatos" y establece visible el panel referente al asesor.
            int cantidad = tablaAsignarAsesor.Rows.Count;
            new FrmMostrarDatos(matriculaSinAsesor, "Asignar").ShowDialog();
            ActualizarTablas();
            if (tablaAsignarAsesor.Rows.Count == 0) {
                lblAlumnoAsignar.Text = "NO HAY ALUMNOS A QUIEN ASIGNARLE UN ASESOR";
                enabledBotones("Asignar", false);
                tablaAsignarAsesor.Enabled = false;
                tablaModificarAsesor.Enabled = true;
                lblAlumnoModificar.Text = "SELECCIONE UN ALUMNO";
            }
            else
            if(cantidad != tablaAsignarAsesor.Rows.Count)
            {
                lblAlumnoAsignar.Text = "SELECCIONE UN ALUMNO";
                enabledBotones("Asignar", false);
                tablaModificarAsesor.Enabled = true;
                lblAlumnoModificar.Text = "SELECCIONE UN ALUMNO";
            }
        }

        private void btnMostrarAsignar_Click(object sender, EventArgs e)
        {
            int cantidad = tablaAsignarAsesor.Rows.Count;
            for (int i = 0; i < alumnosSinAsesor.Count; i++) {
                if (matriculaSinAsesor == alumnosSinAsesor[i].Matricula) {
                    // Abre el formulario "FrmMostrarDatos" y establece visible el panel referente al alumno.
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
                lblAlumnoModificar.Text = "SELECCIONE UN ALUMNO";
            }
            else
            if (cantidad != tablaAsignarAsesor.Rows.Count)
            {
                lblAlumnoAsignar.Text = "SELECCIONE UN ALUMNO";
                enabledBotones("Asignar", false);
                tablaModificarAsesor.Enabled = true;
                lblAlumnoModificar.Text = "SELECCIONE UN ALUMNO";
            }
        }

        private void btnCambiarAsesor_Click(object sender, EventArgs e)
        {
            // Abre el formulario "FrmMostrarDatos" y establece visible el panel referente al asesor.
            new FrmMostrarDatos(matriculaConAsesor, "Cambiar").ShowDialog();
            ActualizarTablas();
        }

        private void btnMostrarModificar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < alumnosConAsesor.Count; i++)
            {
                if (matriculaConAsesor == alumnosConAsesor[i].Matricula)
                {
                    // Abre el formulario "FrmMostrarDatos" y establece visible el panel referente al alumno.
                    new FrmMostrarDatos(alumnosConAsesor, i, "Cambiar").ShowDialog();
                    break;
                }
            }
            ActualizarTablas();
        }
        
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

        String matriculaSinAsesor;
        String matriculaConAsesor;
        private void tablaAsignarAsesor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                enabledBotones("Asignar", true);
                matriculaSinAsesor = tablaAsignarAsesor.Rows[e.RowIndex].Cells["noControlAsignar"].Value.ToString();
                String nombreSeleccionado = tablaAsignarAsesor.Rows[e.RowIndex].Cells["nombreAsignar"].Value.ToString();
                lblAlumnoAsignar.Text = "ALUMNO: " + nombreSeleccionado.ToUpper();
            }
            catch (Exception)
            {
            }
        }

        private void tablaModificarAsesor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                enabledBotones("Cambiar", true);
                matriculaConAsesor = tablaModificarAsesor.Rows[e.RowIndex].Cells["noControlModificar"].Value.ToString();
                String nombreSeleccionado = tablaModificarAsesor.Rows[e.RowIndex].Cells["nombreModificar"].Value.ToString();
                lblAlumnoModificar.Text = "ALUMNO: " + nombreSeleccionado.ToUpper();
            }
            catch (Exception)
            {
            }
            
        }
    }
}