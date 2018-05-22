using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using ResidenciasProfesionales.MODEL;
using ResidenciasProfesionales.DATA;
using System.Windows.Forms;

namespace ResidenciasProfesionales.VIEW
{
    /// <summary>
    /// Lista de solicitudes pendientes de evaluación.
    /// </summary>
    /// <remarks>
    /// Muestra todas aquellos solicitudes en espera de un 
    /// veredicto en forma de lista.
    /// </remarks>
    public partial class FrmAprobacionSolicitud : Form
    {
        /// <summary>
        /// Inicializa los componentes.
        /// </summary>
        public FrmAprobacionSolicitud()
        {
            InitializeComponent();
            cargarDatos();
        }

        /// <summary>
        /// Evento capaz de abrir la ventana FrmMostrarSolicitud
        /// usando la solicitud seleccionado en la lista mostrada.
        /// </summary>
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            FrmMostrarSolicitud frmMostrar = 
                new FrmMostrarSolicitud(SolicitudDAO.ObtenerSolicitud(dgvLista.CurrentRow.Cells[0].Value.ToString()));
            frmMostrar.FormClosed += new FormClosedEventHandler(cargarDatos);
            frmMostrar.Show();
        }

        /// <summary>
        /// Llena la tabla con las solicitudes obtenidas a través
        /// de la consulta a la base de datos.
        /// </summary>
        private void cargarDatos() {
            List <SolicitudPOJO> solicitudes = SolicitudDAO.ObtenerSolicitudesPendientes();
            List <TablaSolicitudes> listaTabla = new List<TablaSolicitudes>();
            if (solicitudes.Count > 0)
            {
                btnMostar.Enabled = true;
                for (int i = 0; i < solicitudes.Count; i++)
                {
                    AlumnoPOJO objAlum = AlumnoDAO.ObtenerAlumno(solicitudes[i].IdAlumno);
                    ResidenciaPOJO objResidencia = ResidenciaDAO.ObtenerResidencia(solicitudes[i].IdResidencia);
                    EmpresaPOJO objEmpresa = EmpresaDAO.ObtenerEmpresa(objResidencia.IdEmpresa);
                    listaTabla.Add(new TablaSolicitudes(objAlum.Matricula, objAlum.NombreCompleto, objAlum.Semestre, objResidencia.NombreProyec,
                        objResidencia.Modalidad, objResidencia.Periodo, objEmpresa.Nombre));
                }
                dgvLista.DataSource = null;
                dgvLista.DataSource = listaTabla;
            }
        }

        /// <summary>
        /// Llena la tabla con las solicitudes obtenidas a través
        /// de la consulta a la base de datos.
        /// </summary>
        private void cargarDatos(object sender, FormClosedEventArgs e)
        {
            List<SolicitudPOJO> solicitudes = SolicitudDAO.ObtenerSolicitudesPendientes();
            List<TablaSolicitudes> listaTabla = new List<TablaSolicitudes>();
            for (int i = 0; i < solicitudes.Count; i++)
            {
                AlumnoPOJO objAlum = AlumnoDAO.ObtenerAlumno(solicitudes[i].IdAlumno);
                ResidenciaPOJO objResidencia = ResidenciaDAO.ObtenerResidencia(solicitudes[i].IdResidencia);
                EmpresaPOJO objEmpresa = EmpresaDAO.ObtenerEmpresa(objResidencia.IdEmpresa);
                listaTabla.Add(new TablaSolicitudes(objAlum.Matricula, objAlum.NombreCompleto, objAlum.Semestre, objResidencia.NombreProyec,
                    objResidencia.Modalidad, objResidencia.Periodo, objEmpresa.Nombre));
            }
            dgvLista.DataSource = null;
            dgvLista.DataSource = listaTabla;
        }
    }
}
