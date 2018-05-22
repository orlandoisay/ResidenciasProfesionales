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
    /// Lista de informes pendientes de la liberación final.
    /// </summary>
    /// <remarks>
    /// Muestra todos aquellos informes en espera de un veredicto
    /// sobre la liberación final de la residencia.
    /// </remarks>
    public partial class FrmLiberacionFinal : Form
    {
        //Almacena al docente ingresado.
        DocentePOJO doce = new DocentePOJO();

        /// <summary>
        /// Inicializa los componentes.
        /// </summary>
        /// <param name="idDocente"></param>
        /// Identificador del docente.
        public FrmLiberacionFinal(String idDocente)
        {
            InitializeComponent();
            doce = DocenteDAO.ObtenerDocente(idDocente);
            cargarDatos();
        }

        /// <summary>
        /// Evento capaz de abrir la ventana FrmLiberacionFinalDetalle
        /// utilizando la residencia seleccionada de la lista.
        /// </summary>
        private void btnLiberar_Click(object sender, EventArgs e)
        {
            ResidenciaPOJO res = ResidenciaDAO.ObtenerResidenciaXMatricula(dgvLista.CurrentRow.Cells[0].Value.ToString());
            FrmLiberacionFinalDetalle frmMostrar = new FrmLiberacionFinalDetalle(res,doce.ID);
            frmMostrar.FormClosed += new FormClosedEventHandler(cargarDatos);
            frmMostrar.Show();
        }

        /// <summary>
        /// Llena la tabla con las residencias obtenidos a través
        /// de la consulta a la base de datos.
        /// </summary>
        private void cargarDatos(object sender, FormClosedEventArgs e)
        {
            List<ResidenciaPOJO> residencias = ResidenciaDAO.ObtenerResidenciaLiberacion();
            List<LiberacionFinalPOJO> liberacionesPendientes = new List<LiberacionFinalPOJO>();

            for (int i = 0; i < residencias.Count; i++) {
                AlumnoPOJO al = AlumnoDAO.ObtenerAlumno(residencias[i].IdAlumno);
                EmpresaPOJO emp = EmpresaDAO.ObtenerEmpresa(residencias[i].IdEmpresa);
                liberacionesPendientes.Add(new LiberacionFinalPOJO(al.Matricula,al.NombreCompleto,
                    residencias[i].NombreProyec,emp.Nombre, residencias[i].IdEmpresa));
            }

            dgvLista.DataSource = null;
            dgvLista.DataSource = liberacionesPendientes;
        }

        /// <summary>
        /// Llena la tabla con las residencias obtenidos a través
        /// de la consulta a la base de datos.
        /// </summary>
        private void cargarDatos() {
            List<ResidenciaPOJO> residencias = ResidenciaDAO.ObtenerResidenciaLiberacion();
            List<LiberacionFinalPOJO> liberacionesPendientes = new List<LiberacionFinalPOJO>();

            for (int i = 0; i < residencias.Count; i++)
            {
                AlumnoPOJO al = AlumnoDAO.ObtenerAlumno(residencias[i].IdAlumno);
                EmpresaPOJO emp = EmpresaDAO.ObtenerEmpresa(residencias[i].IdEmpresa);
                liberacionesPendientes.Add(new LiberacionFinalPOJO(al.Matricula, al.NombreCompleto,
                    residencias[i].NombreProyec, emp.Nombre, residencias[i].IdEmpresa));
            }

            dgvLista.DataSource = null;
            dgvLista.DataSource = liberacionesPendientes;
        }
    }
}
