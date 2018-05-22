using ResidenciasProfesionales.DATA;
using ResidenciasProfesionales.MODEL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ResidenciasProfesionales.VIEW
{
    /// <summary>
    /// Liberación final de residencias.
    /// </summary>
    public partial class FrmLiberacionFinalDetalle : Form
    {
        ResidenciaPOJO resi = new ResidenciaPOJO();
        DocentePOJO doce = new DocentePOJO();

        /// <summary>
        /// Llena los componentes encargados de mostrar los datos
        /// necesarios para la liberación final.
        /// </summary>
        /// <param name="res"></param>
        /// Residencias previamente seleccionada.
        /// <param name="idDocente"></param>
        /// Identificador del docente.
        public FrmLiberacionFinalDetalle(ResidenciaPOJO res, String idDocente)
        {
            InitializeComponent();
            resi = res;
            doce = DocenteDAO.ObtenerDocente(idDocente);
            AlumnoPOJO al = AlumnoDAO.ObtenerAlumno(res.IdAlumno);
            txtCarrera.Text = CarreraDAO.ObtenerUno(al.Carrera).Nombre;
            txtNoControl.Text = al.Matricula;
            txtNombre.Text = al.NombreCompleto;
            txtSemestre.Text = al.Semestre + "";
        }

        private void FrmLiberacionFinalDetalle_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Crea e ingresa el dictamen LiberaciónFinal en la base de 
        /// datos, además cierra la ventana actual.
        /// </summary>
        private void btnEvaluar_Click(object sender, EventArgs e)
        {
            String fecha = DateTime.Now.ToString("yyyy-MM-dd");
            DictamenDAO.InsertarDictamen(new DictamenPOJO(1,resi.ID,doce.ID, "LiberacionFinal", "Aceptado",txtComentarios.Text,(int)spnCal.Value,DateTime.Parse(fecha)));
            this.Close();
        }
    }
}
