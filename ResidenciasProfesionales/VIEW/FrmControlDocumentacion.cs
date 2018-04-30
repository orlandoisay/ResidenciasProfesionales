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
    public partial class FrmControlDocumentacion : Form
    {
        List<AlumnoPOJO> alumnosConAsesor = new List<AlumnoPOJO>();
        String idDocente;

        public FrmControlDocumentacion(String idDocente)
        {
            InitializeComponent();
            insertarDocumentos();
            this.idDocente = idDocente;

            tablaDocumentos.Enabled = false;
            spnCalificacionFinal.Enabled = false;
            lblComentario.Visible = false;
            txtaComentario.Visible = false;
            llenarTablaAlumno();
            btnGuardarCambios.Enabled = false;
            if (tablaAlumnos.Rows.Count == 0)
            {
                lblNombreAlumno.Text = "NO HAY ASESORADOS CON DOCUMENTACIÓN PENDIENTE";
                tablaAlumnos.Enabled = false;
            }
            else
            {
                lblNombreAlumno.Text = "SELECCIONE UN ALUMNO";
            }
        }

        public void llenarTablaAlumno() {
            tablaAlumnos.Rows.Clear();
            alumnosConAsesor = AlumnoDAO.ObtenerAlumnosConAsesorSinLiberarlo(idDocente);
            DocentePOJO asesor;

            for (int i = 0; i < alumnosConAsesor.Count; i++)
            {
                asesor = DocenteDAO.ObtenerDocenteXMatricula(alumnosConAsesor[i].Matricula);
                tablaAlumnos.Rows.Add(alumnosConAsesor[i].Matricula, alumnosConAsesor[i].NombreCompleto, asesor.NombreCompleto);
            }
        }

        public void insertarDocumentos() {
            tablaDocumentos.Rows.Add("Cronograma de actividades");
            tablaDocumentos.Rows.Add("Informe");
            tablaDocumentos.Rows.Add("Resumen ejecutivo");
            tablaDocumentos.Rows.Add("CD");
            tablaDocumentos.Rows.Add("Asesorias");
            tablaDocumentos.Rows.Add("Documento de evaluación");
        }

        String matricula;
        private void tablaAlumnos_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                btnGuardarCambios.Enabled = false;
                matricula = tablaAlumnos.Rows[e.RowIndex].Cells["noControl"].Value.ToString();
                String nombreSeleccionado = tablaAlumnos.Rows[e.RowIndex].Cells["nombre"].Value.ToString();
                lblNombreAlumno.Text = "ALUMNO: " + nombreSeleccionado.ToUpper();
                spnCalificacionFinal.Value = 0;
                txtaComentario.Text = "";
                palomearChecks();
            }
            catch (Exception)
            {
                btnGuardarCambios.Enabled = false;
            }
            
        }

        public void palomearChecks() {
            for (int i  = 3; i < 9; i++) {
                if (EntregaDAO.ObtenerEntrega(matricula, i).Estado == "Entregado") {
                    tablaDocumentos[1, (i-3)].Value = true;
                }
                else {
                    tablaDocumentos[1, (i-3)].Value = false;
                }
            }
            entregoTodos();
        }

        public void limpiarChecks()
        {
            for (int i = 3; i < 9; i++)
            {
                    tablaDocumentos[1, (i - 3)].Value = false;
            }
        }

        private void lblCalificacionFinal_Click(object sender, EventArgs e)
        {
        }

        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            if (spnCalificacionFinal.Enabled == false) {

                DialogResult dr = MessageBox.Show("¿Mantener los cambios realizados?" + spnCalificacionFinal.Value, "Info",
                                              MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.No)
                    return;

                for (int i = 3; i < 9; i++)
                {
                    if (tablaDocumentos[1, (i - 3)].Value.Equals(true))
                    {
                        EntregaDAO.CambiarEstadoDocumento("Entregado", matricula, i);
                    }
                    else {
                        EntregaDAO.CambiarEstadoDocumento("Pendiente", matricula, i);
                    }
                }
                MessageBox.Show("Documentos guardados con exito", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnGuardarCambios.Enabled = false;
                entregoTodos();
            } else if (spnCalificacionFinal.Enabled == true)
            {

                DialogResult dr = MessageBox.Show("Crear el dictamen \"liberación asesor\" con una calificación final de "+spnCalificacionFinal.Value, "Info",
                                              MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.No)
                    return;

                ResidenciaPOJO residencia = ResidenciaDAO.ObtenerResidenciaXMatricula(matricula);
                String estatus;
                if (spnCalificacionFinal.Value>=70) {
                    estatus = "Aceptado";
                }
                else {
                    estatus = "Rechazado";
                }
                String fecha = DateTime.Now.Year + "-" + DateTime.Now.Month + "-" + DateTime.Now.Day;
                DictamenPOJO nuevoDictamen = new DictamenPOJO(0, residencia.ID, idDocente, "LiberacionAsesor",
                    estatus, txtaComentario.Text, int.Parse(spnCalificacionFinal.Value+""), DateTime.Parse(fecha));
                DictamenDAO.InsertarDictamen(nuevoDictamen);
                MessageBox.Show("Dictamen creado con exito", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                llenarTablaAlumno();
                bloquearDesbloquear(false);
                btnGuardarCambios.Enabled = false;
                spnCalificacionFinal.Value = 0;
                limpiarChecks();
                tablaDocumentos.Enabled = false;
                if (tablaAlumnos.Rows.Count == 0)
                {
                    lblNombreAlumno.Text = "NO HAY ASESORADOS CON DOCUMENTACIÓN PENDIENTE";
                    tablaAlumnos.Enabled = false;
                }
                else
                {
                    lblNombreAlumno.Text = "SELECCIONE UN ALUMNO";
                }
            }
        }

        public void entregoTodos() {
            for (int i = 0; i < 6; i++)
            {
                if (tablaDocumentos[1, i].Value.Equals(false)) {
                    bloquearDesbloquear(false);
                    return;
                }
            }
            bloquearDesbloquear(true);
        }

        public void bloquearDesbloquear(bool bandera) {
            if (bandera == true)
            {
                tablaDocumentos.Enabled = false;
                spnCalificacionFinal.Enabled = true;
                btnGuardarCambios.Text = "Guardar Calificación";
                lblComentario.Visible = true;
                txtaComentario.Visible = true;
                btnGuardarCambios.Enabled = true;
            }
            else {
                tablaDocumentos.Enabled = true;
                spnCalificacionFinal.Enabled = false;
                btnGuardarCambios.Text = "Guardar Documentación";
                lblComentario.Visible = false;
                txtaComentario.Visible = false;
            }
        }

        private void tablaDocumentos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnGuardarCambios.Enabled = true;
        }
    }
}