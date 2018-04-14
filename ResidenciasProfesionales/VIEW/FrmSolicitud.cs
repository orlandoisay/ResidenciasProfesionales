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
    public partial class FrmSolicitud : Form
    {
        private bool esEdicion = false;

        public FrmSolicitud(string matricula)
        {
            InitializeComponent();
            var alumno = AlumnoDAO.ObtenerAlumno(matricula);
            var solicitud = SolicitudDAO.ObtenerSolicitud(matricula);

            CargarDatosAlumno(alumno);

            if (solicitud != null)
            {
                CargarDatosSolicitud(solicitud);
                esEdicion = true;
            }
        }     
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!ValidarDatos())
                return;

            if (esEdicion)
                GuardarDatos();
            else
                ModificarDatos();
        }
        private void btnImprimir_Click(object sender, EventArgs e)
        {
            ImprimirSolicitud();
        }

        private void CargarDatosAlumno(AlumnoPOJO alumno)
        {
            txtResNoControl.Text = alumno.Matricula;
            txtResNombre.Text = alumno.NombreCompleto;
            cmbResCarrera.SelectedIndex = alumno.Carrera - 1;
            txtResDomicilio.Text = alumno.Domicilio;
            txtResCiudad.Text = alumno.Ciudad;
            txtResEmail.Text = alumno.Correo;
            txtResTelefono.Text = alumno.Telefono;

            switch(alumno.TipoSS)
            {
                case "IMSS":
                    rbtnResSSIMSS.Checked = true;
                    break;
                case "ISSSTE":
                    rbtnResSSISSSTE.Checked = true;
                    break;
                case "Otro":
                    rbtnResSSOtro.Checked = true;
                    break;
            }
            txtResSSNumero.Text = alumno.NumeroSS;

        }
        private void CargarDatosSolicitud(SolicitudPOJO solicitud)
        {
            var residencia = ResidenciaDAO.ObtenerResidencia(solicitud.IdResidencia);
            var empresa = EmpresaDAO.ObtenerEmpresa(residencia.IdEmpresa);

            // Cargado de datos del proyecto

            txtProNombre.Text = residencia.NombreProyec;

            switch (residencia.Modalidad)
            {
                case "Banco de proyectos":
                    rbtnProTipoBanco.Checked = true;
                    break;
                case "Propuesta propia":
                    rbtnProTipoPropia.Checked = true;
                    break;
                case "Trabajador":
                    rbtnProTipoTrabajador.Checked = true;
                    break;
            }

            cmbProPeriodo.SelectedItem = residencia.Periodo;

            // Cargado de datos de la empresa

            txtEmpRFC.Text = empresa.RFC;
            txtEmpNombre.Text = empresa.Nombre;

            switch (empresa.Sector)
            {
                case "Industrial":
                    rbtnEmpGiroIndustrial.Checked = true;
                    break;
                case "Servicios":
                    rbtnEmpGiroServicios.Checked = true;
                    break;
                case "Otro":
                    rbtnEmpGiroOtro.Checked = true;
                    break;
            }

            txtEmpDomicilio.Text = empresa.Domicilio;
            txtEmpColonia.Text = empresa.Colonia;
            txtEmpCP.Text = empresa.CP;
            txtEmpFax.Text = empresa.Fax;
            txtEmpCiudad.Text = empresa.Ciudad;
            txtEmpTelefono.Text = empresa.Telefono;
            txtEmpMision.Text = empresa.Mision;

            txtEmpTitularNombre.Text = empresa.Titular;
            txtEmpTitularPuesto.Text = empresa.PuestoTit;
            txtEmpAsesorNombre.Text = residencia.AsesorExt;
            txtEmpAsesorPuesto.Text = residencia.PuestoAsesor;
            txtEmpFirmaNombre.Text = residencia.Responsable;
            txtEmpFirmaPuesto.Text = residencia.PuestoResp;


        }
        private bool ValidarDatos()
        {
            //TODO: Implementar validaciones
            return false;
        }
        private bool GuardarDatos()
        {

            // TODO: Implementar el metodo de guardado

            // Insertar datos de la empresa

            string sector = "";

            if (rbtnEmpGiroIndustrial.Checked)
                sector = "Industrial";
            if (rbtnEmpGiroServicios.Checked)
                sector = "Servicios";
            if (rbtnEmpGiroOtro.Checked)
                sector = "Otro";

            EmpresaDAO.InsertarEmpresa(
                new EmpresaPOJO(txtEmpRFC.Text,
                                txtEmpNombre.Text,
                                sector,
                                txtEmpDomicilio.Text,
                                txtEmpColonia.Text,
                                txtEmpCiudad.Text,
                                txtEmpCP.Text,
                                txtEmpTelefono.Text,
                                txtEmpFax.Text,
                                txtEmpMision.Text,
                                txtEmpTitularNombre.Text,
                                txtEmpTitularPuesto.Text));
            return false;
        }
        private bool ModificarDatos()
        {
            // TODO: Implementar el metodo de modificado
            return false;
        }
        private void ImprimirSolicitud()
        {
            // TODO: Implementar el metodo de impresion
            // TODO: Crear la clase que se encarga de generar archivos de Excel
        }
    }
}
