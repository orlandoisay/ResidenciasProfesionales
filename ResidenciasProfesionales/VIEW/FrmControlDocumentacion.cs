﻿using System;
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
    /// Clase encargada de controlar la entrega de documentación
    /// así como de la asignación de calificación.
    /// </summary>
    public partial class FrmControlDocumentacion : Form
    {
        // Lista de alumnos.
        List<AlumnoPOJO> alumnosConAsesor = new List<AlumnoPOJO>();
        // Almacena el identificador del docente.
        String idDocente;

        /// <summary>
        /// Evalua si hay o no alumnos con documentación pendiente,
        /// y dependiendo de ello, permitir o limitar las 
        /// opciones proporcionadas.
        /// </summary>
        public FrmControlDocumentacion(String idDocente)
        {
            InitializeComponent();
            insertarDocumentos();
            this.idDocente = idDocente;
            btnCorregir.Visible = false;

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
                tablaAlumnos.Rows[0].Selected = true;
                llenarEspacios(0);
                //lblNombreAlumno.Text = "SELECCIONE UN ALUMNO";
            }
        }

        /// <summary>
        /// Actualiza las tablas después de cada modificación.
        /// </summary>
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

        /// <summary>
        /// Inserta los documentos en la base de datos con el estado
        /// pendiente para su posterior modificación.
        /// </summary>
        public void insertarDocumentos() {
            tablaDocumentos.Rows.Add("Cronograma de actividades");
            tablaDocumentos.Rows.Add("Informe técnico de residencias");
            tablaDocumentos.Rows.Add("Resumen ejecutivo");
            tablaDocumentos.Rows.Add("CD");
            tablaDocumentos.Rows.Add("Asesorias");
            tablaDocumentos.Rows.Add("Documento de evaluación");
        }

        // Almacena la matricula del alumno seleccionado.
        String matricula;

        /// <summary>
        /// Evento capaz de reconocer la fila seleccionada.
        /// </summary>
        private void tablaAlumnos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                tablaAlumnos.Rows[e.RowIndex].Selected = true;
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

        public void llenarEspacios(int index) {
            btnGuardarCambios.Enabled = false;
            matricula = tablaAlumnos.Rows[index].Cells["noControl"].Value.ToString();
            String nombreSeleccionado = tablaAlumnos.Rows[index].Cells["nombre"].Value.ToString();
            lblNombreAlumno.Text = "ALUMNO: " + nombreSeleccionado.ToUpper();
            spnCalificacionFinal.Value = 0;
            txtaComentario.Text = "";
            palomearChecks();
        }

        /// <summary>
        /// Revisa cuales documentos ya fueron entregados para marcarlos
        /// en las casillas de verificación.
        /// </summary>
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

        /// <summary>
        /// Establece el valor false en todas las casillas de 
        /// verificación.
        /// </summary>
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

        /// <summary>
        /// Almacena todos los cambios realizados en la
        /// base de datos.
        /// </summary>
        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            if (spnCalificacionFinal.Enabled == false) {

                DialogResult dr = MessageBox.Show("¿Mantener los cambios realizados?", "Info",
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
                    btnCorregir.Visible = false;
                    tablaAlumnos.Enabled = false;
                }
                else
                {
                    tablaAlumnos.Rows[0].Selected = true;
                    llenarEspacios(0);
                    //lblNombreAlumno.Text = "SELECCIONE UN ALUMNO";
                    btnGuardarCambios.Enabled = true;
                }
            }
        }

        /// <summary>
        /// Revisa si la totalidad de los documentos ya han sido
        /// entregados.
        /// </summary>
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

        /// <summary>
        /// Habilita/deshabilita los botones.
        /// </summary>
        public void bloquearDesbloquear(bool bandera) {
            if (bandera == true)
            {
                tablaDocumentos.Enabled = false;
                spnCalificacionFinal.Enabled = true;
                btnGuardarCambios.Text = "Guardar Calificación";
                lblComentario.Visible = true;
                txtaComentario.Visible = true;
                btnGuardarCambios.Enabled = true;
                btnCorregir.Visible = true;
            }
            else {
                tablaDocumentos.Enabled = true;
                spnCalificacionFinal.Enabled = false;
                btnGuardarCambios.Text = "Guardar Documentación";
                lblComentario.Visible = false;
                txtaComentario.Visible = false;
            }
        }

        /// <summary>
        /// Si no se ha seleccionado algún alumno, no se permite
        /// guardar cambios.
        /// </summary>
        private void tablaDocumentos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnGuardarCambios.Enabled = true;
        }

        private void btnCorregir_Click(object sender, EventArgs e)
        {
            bloquearDesbloquear(false);
            btnCorregir.Visible = false;
            spnCalificacionFinal.Value = 0;
            txtaComentario.Text = "";
        }
    }
}