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
    public partial class FrmMostrarCalificaciones : Form
    {
        String idDocente;
        List<AlumnoPOJO> alumnos = new List<AlumnoPOJO>();
        List<DictamenPOJO> dictamenes = new List<DictamenPOJO>();

        public FrmMostrarCalificaciones(String ID)
        {
            InitializeComponent();
            idDocente = ID;
            llenarTablaAlumno();
            if (tablaCalificaciones.Rows.Count == 0)
            {
                lblComentario.Text = "NO HAY CALIFICACIONES PARA MOSTRAR";
                tablaCalificaciones.Enabled = false;
            }
            else {
                lblComentario.Text = "SELECCIONE UN ALUMNO DE LA LISTA";
            }
            txtaComentario.Visible = false;
            lblFecha.Visible = false;
        }

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

        private void tablaCalificaciones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
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

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
