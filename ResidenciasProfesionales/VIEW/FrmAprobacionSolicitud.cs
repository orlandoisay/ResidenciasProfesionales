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
    public partial class FrmAprobacionSolicitud : Form
    {
        public FrmAprobacionSolicitud()
        {
            InitializeComponent();
            cargarDatos();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            FrmMostrarSolicitud frmMostrar = 
                new FrmMostrarSolicitud(SolicitudDAO.ObtenerSolicitud(dgvLista.CurrentRow.Cells[0].Value.ToString()));
            frmMostrar.FormClosed += new FormClosedEventHandler(cargarDatos);
            frmMostrar.Show();
        }

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
