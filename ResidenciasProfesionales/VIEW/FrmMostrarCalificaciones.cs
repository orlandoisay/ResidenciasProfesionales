using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ResidenciasProfesionales.MODEL;
using ResidenciasProfesionales.DATA;

namespace ResidenciasProfesionales.VIEW
{
    /// <summary>
    /// Permite visualizar las calificaciones emitidas por el 
    /// asesor.
    /// </summary>
    public partial class FrmMostrarCalificaciones : Form
    {
        String idDocente;
        int idDictamen;
        List<AlumnoPOJO> alumnos = new List<AlumnoPOJO>();
        List<DictamenPOJO> dictamenes = new List<DictamenPOJO>();

        /// <summary>
        /// Evalua si hay o no alumnos para mostrar, y dependiendo 
        /// de ello, permitir o limitar las opciones proporcionadas.
        /// </summary>
        public FrmMostrarCalificaciones(String ID)
        {
            InitializeComponent();
            idDocente = ID;
            iniciar();
        }

        public void iniciar() {
            llenarTablaAlumno();
            txtaComentario.Visible = false;
            lblFecha.Visible = false;
            if (tablaCalificaciones.Rows.Count == 0)
            {
                lblComentario.Text = "NO HAY CALIFICACIONES PARA MOSTRAR";
                btnCambiar.Enabled = false;
                tablaCalificaciones.Enabled = false;
            }
            else
            {
                tablaCalificaciones.Rows[0].Selected = true;
                llenarEspacios(0);
                idDictamen = dictamenes[0].ID;
                //lblComentario.Text = "SELECCIONE UN ALUMNO DE LA LISTA";
            }
        }


        /// <summary>
        /// Llena la tabla con las listas previamente cargadas.
        /// </summary>
        public void llenarTablaAlumno()
        {
            tablaCalificaciones.Rows.Clear();
            alumnos = AlumnoDAO.ObtenerAlumnosConLiberacionAsesor(idDocente);
            dictamenes = DictamenDAO.ObtenerLiberacionesAsesor(idDocente);

            for (int i = 0; i < alumnos.Count; i++)
            {
                tablaCalificaciones.Rows.Add(alumnos[i].Matricula, alumnos[i].NombreCompleto, dictamenes[i].Estatus, dictamenes[i].Calificacion);
            }
        }

        /// <summary>
        /// Evento capaz de reconocer la fila seleccionada
        /// y cargar los datos de la misma en los componentes
        /// correspondientes.
        /// </summary>
        private void tablaCalificaciones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                idDictamen = dictamenes[e.RowIndex].ID;
                tablaCalificaciones.Rows[e.RowIndex].Selected = true;
                txtaComentario.Visible = true;
                lblFecha.Visible = true;
                lblComentario.Text = "Comentario:";

                String fecha = dictamenes[e.RowIndex].Fecha.Day + "/" + dictamenes[e.RowIndex].Fecha.Month + "/" + dictamenes[e.RowIndex].Fecha.Year;
                lblFecha.Text = "Fecha: " + fecha;
                txtaComentario.Text = dictamenes[e.RowIndex].Comentario;
            }
            catch (Exception)
            {
            }
        }

        public void llenarEspacios(int index) {
            txtaComentario.Visible = true;
            lblFecha.Visible = true;
            lblComentario.Text = "Comentario:";

            String fecha = dictamenes[index].Fecha.Day + "/" + dictamenes[index].Fecha.Month + "/" + dictamenes[index].Fecha.Year;
            lblFecha.Text = "Fecha: " + fecha;
            txtaComentario.Text = dictamenes[index].Comentario;
        }

        /// <summary>
        /// Cierra la ventana actual.
        /// </summary>
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCambiar_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("¿Seguro que desea cambiar esta información?", "Info",
                                              MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.No)
                return;

            DictamenDAO.BorrarDictamen(idDictamen);
            var frmControlDocumentacion = new FrmControlDocumentacion(idDocente);
            this.Visible = false;
            frmControlDocumentacion.ShowDialog();
            iniciar();
            this.Visible = true;
        }
    }
}
