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
    /// Lista de informes pendientes de evaluación.
    /// </summary>
    /// <remarks>
    /// Muestra todos aquellos informes en espera de un veredicto
    /// en forma de lista.
    /// </remarks>
    public partial class FrmAprobacionInformeLista : Form
    {
        private String IdDocente;
        private String RolDocente;

        /// <summary>
        /// Inicializa los componentes.
        /// </summary>
        /// <param name="idDocente"></param>
        /// Identificador del docente.
        /// <param name="rolDocente"></param>
        /// Contiene el rol del docente ingresado.
        public FrmAprobacionInformeLista(String idDocente, String rolDocente)
        {
            IdDocente = idDocente;
            RolDocente = rolDocente;
            InitializeComponent();
            dgvLista.AutoGenerateColumns = false;
            CargarInformes();
        }

        /// <summary>
        /// Evento capaz de abrir la ventana FrmAprobacionInforme
        /// usando el informe seleccionado en la lista mostrada.
        /// </summary>
        private void btnEvaluar_Click(object sender, EventArgs e)
        {
            if(dgvLista.SelectedRows.Count == 0)
            {
                MessageBox.Show("Debe seleccionar un registro.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var matricula = dgvLista.SelectedRows[0].Cells[0].Value.ToString();
            var frmAprobacionInforme = new FrmAprobacionInforme(IdDocente, matricula);
            frmAprobacionInforme.ShowDialog();
            CargarInformes();
        }

        /// <summary>
        /// Llena la tabla con los informes obtenidos a través
        /// de la consulta a la base de datos.
        /// </summary>
        private void CargarInformes()
        {
            var listaInformes = InformeDAO.ObtenerInformesPorPeriodo(Properties.Settings.Default.Anio,
                                                                     Properties.Settings.Default.Periodo,
                                                                     IdDocente,
                                                                     RolDocente,
                                                                     false);

            dgvLista.DataSource = listaInformes;
        }
    }
}
