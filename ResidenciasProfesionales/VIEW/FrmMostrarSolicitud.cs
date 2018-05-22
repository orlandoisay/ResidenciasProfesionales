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
    /// Muestra las solicitudes elaboradas previamente.
    /// </summary>
    public partial class FrmMostrarSolicitud : Form
    {
        /// <summary>
        /// Permite visualizar las solicitudes para emitir su 
        /// aceptación o modificación.
        /// </summary>
        private SolicitudPOJO Solicitud = null;

        /// <summary>
        /// Inicializa los componentes.
        /// </summary>
        public FrmMostrarSolicitud(SolicitudPOJO solicitud)
        {
            InitializeComponent();
            Solicitud = solicitud;
            cargarDatos();
        }

        /// <summary>
        /// Llena los componentes encargados de mostrar los datos 
        /// de la solicitud seleccionada previamente.
        /// </summary>
        private void cargarDatos() {
            AlumnoPOJO objAlum = AlumnoDAO.ObtenerAlumno(Solicitud.IdAlumno);
            ResidenciaPOJO objResidencia = ResidenciaDAO.ObtenerResidencia(Solicitud.IdResidencia);
            EmpresaPOJO objEmpresa = EmpresaDAO.ObtenerEmpresa(objResidencia.IdEmpresa);

            txtResNoControl.Text = objAlum.Matricula;
            txtResNombre.Text = objAlum.NombreCompleto;
            cmbResCarrera.Text = CarreraDAO.ObtenerUno(objAlum.Carrera).Nombre;
            txtResDomicilio.Text = objAlum.Domicilio;
            txtResCiudad.Text = objAlum.Ciudad;
            txtResEmail.Text = objAlum.Correo;
            txtResTelefono.Text = objAlum.Telefono;
            if (objAlum.TipoSS == "IMSS")
                rbtnResSSIMSS.Checked = true;
            else if (objAlum.TipoSS == "ISSSTE")
                rbtnResSSISSSTE.Checked = true;
            else
                rbtnResSSOtro.Checked = true;
            txtResSSNumero.Text = objAlum.NumeroSS + "";

            txtProNombre.Text = objResidencia.NombreProyec;
            if (objResidencia.Modalidad == "Banco de proyectos")
                rbtnProTipoBanco.Checked = true;
            else if (objResidencia.Modalidad == "Propuesta propia")
                rbtnProTipoPropia.Checked = true;
            else
                rbtnProTipoTrabajador.Checked = true;
            cmbProPeriodo.Text = objResidencia.Periodo;

            txtEmpRFC.Text = objEmpresa.RFC;
            txtEmpNombre.Text = objEmpresa.Nombre;
            if (objEmpresa.Giro == "Industrial")
                rbtnEmpGiroIndustrial.Checked = true;
            else if (objEmpresa.Giro == "Servicios")
                rbtnEmpGiroServicios.Checked = true;
            else
                rbtnEmpGiroOtro.Checked = true;
            if (objEmpresa.Sector == "Publico")
                rbtnEmpTipoPublica.Checked = true;
            else
                rbtnEmpTipoPrivada.Checked = true;
            txtEmpDomicilio.Text = objEmpresa.Domicilio;
            txtEmpColonia.Text = objEmpresa.Colonia;
            txtEmpCP.Text = objEmpresa.CP;
            txtEmpFax.Text = objEmpresa.Fax;
            txtEmpCiudad.Text = objEmpresa.Ciudad;
            txtEmpTelefono.Text = objEmpresa.Telefono;
            txtEmpMision.Text = objEmpresa.Mision;
            txtEmpTitularNombre.Text = objEmpresa.Titular;
            txtEmpTitularPuesto.Text = objEmpresa.PuestoTit;
            txtEmpFirmaNombre.Text = objResidencia.Responsable;
            txtEmpFirmaPuesto.Text = objResidencia.PuestoResp;
            txtEmpAsesorNombre.Text = objResidencia.AsesorExt;
            txtEmpAsesorPuesto.Text = objResidencia.PuestoAsesor;
        }

        /// <summary>
        /// Emite la aceptación de la solicitud seleccionada y
        /// además cierra la ventana actual.
        /// </summary>
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            SolicitudDAO.Actualizar(Solicitud);
            this.Close();
        }
    }
}
