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
            btnAsignar.Enabled = false;
            btnMostrarAsignar.Enabled = false;
            btnCambiarAsesor.Enabled = false;
            btnMostrarModificar.Enabled = false;
        }

        List<AlumnoPOJO> alumnosSinAsesor = new List<AlumnoPOJO>();
        List<AlumnoPOJO> alumnosConAsesor = new List<AlumnoPOJO>();

        private void btnAsignar_Click(object sender, EventArgs e)
        {
            // Abre el formulario "FrmMostrarDatos" y establece visible el panel referente al asesor.
            new FrmMostrarDatos(matriculaSinAsesor, "Asignar").ShowDialog();
            ActualizarTablas();
        }

        private void btnMostrarAsignar_Click(object sender, EventArgs e)
        {
            
            for (int i = 0; i < alumnosSinAsesor.Count; i++) {
                if (matriculaSinAsesor == alumnosSinAsesor[i].Matricula) {
                    // Abre el formulario "FrmMostrarDatos" y establece visible el panel referente al alumno.
                    new FrmMostrarDatos(alumnosSinAsesor, i, "Asignar").ShowDialog();
                    break;
                }
            }
            ActualizarTablas();

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
            alumnosConAsesor = AlumnoDAO.ObtenerAlumnosConAsesor();
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
                btnAsignar.Enabled = true;
                btnMostrarAsignar.Enabled = true;
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
                btnCambiarAsesor.Enabled = true;
                btnMostrarModificar.Enabled = true;
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