using ResidenciasProfesionales.DATA;
using ResidenciasProfesionales.MODEL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ResidenciasProfesionales.VIEW
{
    public partial class FrmSolicitud : Form
    {
        private bool esEdicion = false;
        private AlumnoPOJO alumno;

        /// <summary>
        /// Muestra una ventana en la que un alumno puede llenar
        /// su solicitud, e imprimirla.
        /// </summary>
        /// <param name="matricula">Matricula del alumno en cuestión.</param>
        public FrmSolicitud(string matricula)
        {
            InitializeComponent();
            cmbResCarrera.DataSource = CarreraDAO.ObtenerTodas();
            cmbResCarrera.DisplayMember = "Nombre";
            cmbResCarrera.ValueMember = "ID";

            alumno = AlumnoDAO.ObtenerAlumno(matricula);
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
                ModificarDatos();
            else
                GuardarDatos();
        }
        private void btnImprimir_Click(object sender, EventArgs e)
        {
            ImprimirSolicitud();
        }

        private void CargarDatosAlumno(AlumnoPOJO alumno)
        {
            txtResNoControl.Text = alumno.Matricula;
            txtResNombre.Text = alumno.NombreCompleto;
            cmbResCarrera.SelectedValue = alumno.Carrera;
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
            if (solicitud.Estatus == "Aceptado")
                btnGuardar.Enabled = false;

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

            switch (empresa.Giro)
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

            switch (empresa.Sector)
            {
                case "Publico":
                    rbtnEmpTipoPublica.Checked = true;
                    break;
                case "Privado":
                    rbtnEmpTipoPrivada.Checked = true;
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
            bool datosValidados = true;
            String mensajeError = "Es necesario corregir los siguientes campos:\n";

            // Validaciones de empresa

            if (!(new Regex("[A-Z0-9]{13}").IsMatch(txtEmpRFC.Text)))
            {
                datosValidados = false;
                mensajeError += " - R.F.C. de la empresa\n";
            }

            if (txtEmpNombre.Text.Trim().Length == 0)
            {
                datosValidados = false;
                mensajeError += " - Nombre de la empresa\n";
            }

            if (!rbtnEmpGiroIndustrial.Checked &&
                !rbtnEmpGiroServicios.Checked &&
                !rbtnEmpGiroOtro.Checked)
            {
                datosValidados = false;
                mensajeError += " - Giro de la empresa\n";
            }

            if (!rbtnEmpTipoPublica.Checked &&
                !rbtnEmpTipoPrivada.Checked)
            {
                datosValidados = false;
                mensajeError += " - Secto de la empresa\n";
            }

            if (txtEmpDomicilio.Text.Trim().Length == 0)
            {
                datosValidados = false;
                mensajeError += " - Domicilio de la empresa\n";
            }

            if (txtEmpColonia.Text.Trim().Length == 0)
            {
                datosValidados = false;
                mensajeError += " - Colonia de la empresa\n";
            }

            if (!(new Regex("[0-9]{5}").IsMatch(txtEmpCP.Text)))
            {
                datosValidados = false;
                mensajeError += " - Código Postal de la empresa\n";
            }


            if (txtEmpCiudad.Text.Trim().Length == 0)
            {
                datosValidados = false;
                mensajeError += " - Ciudad de la empresa\n";
            }

            if (!(new Regex("[0-9]{10}").IsMatch(txtEmpTelefono.Text)))
            {
                datosValidados = false;
                mensajeError += " - Teléfono de la empresa\n";
            }

            if (txtEmpMision.Text.Trim().Length == 0)
            {
                datosValidados = false;
                mensajeError += " - Misión de la empresa\n";
            }

            if (txtEmpTitularNombre.Text.Trim().Length == 0)
            {
                datosValidados = false;
                mensajeError += " - Nombre del titular de la empresa\n";
            }

            if (txtEmpTitularPuesto.Text.Trim().Length == 0)
            {
                datosValidados = false;
                mensajeError += " - Puesto del titular de la empresa\n";
            }

            if (txtEmpAsesorNombre.Text.Trim().Length == 0)
            {
                datosValidados = false;
                mensajeError += " - Nombre del asesor externo de la empresa\n";
            }

            if (txtEmpAsesorPuesto.Text.Trim().Length == 0)
            {
                datosValidados = false;
                mensajeError += " - Puesto del asesor externo de la empresa\n";
            }

            if (txtEmpFirmaNombre.Text.Trim().Length == 0)
            {
                datosValidados = false;
                mensajeError += " - Nombre de la persona que firmará por la empresa\n";
            }

            if (txtEmpFirmaPuesto.Text.Trim().Length == 0)
            {
                datosValidados = false;
                mensajeError += " - Puesto de la persona que firmará por la empresa\n";
            }

            // Validaciones de proyecto
            if (txtProNombre.Text.Trim().Length == 0)
            {
                datosValidados = false;
                mensajeError += " - Nombre del proyecto\n";
            }

            if (!rbtnProTipoBanco.Checked &&
                !rbtnProTipoPropia.Checked &&
                !rbtnProTipoTrabajador.Checked)
            {
                datosValidados = false;
                mensajeError += " - Tipo de proyecto\n";
            }

            if (cmbProPeriodo.SelectedIndex == -1)
            {
                datosValidados = false;
                mensajeError += " - Periodo proyectado para el proyecto\n";
            }

            // Implementar validaciones de alumno
            if (txtResDomicilio.Text.Trim().Length == 0)
            {
                datosValidados = false;
                mensajeError += " - Domicilio del residente\n";
            }

            if (txtResCiudad.Text.Trim().Length == 0)
            {
                datosValidados = false;
                mensajeError += " - Ciudad del residente\n";
            }

            if (!(new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$").IsMatch(txtResEmail.Text)))
            {
                datosValidados = false;
                mensajeError += " - Correo electrónico del residente\n";
            }

            if (!(new Regex("[0-9]{10}").IsMatch(txtResTelefono.Text)))
            {
                datosValidados = false;
                mensajeError += " - Teléfono del residente\n";
            }

            if (!rbtnResSSIMSS.Checked &&
                !rbtnResSSISSSTE.Checked &&
                !rbtnResSSOtro.Checked)
            {
                datosValidados = false;
                mensajeError += " - Tipo de seguridad social\n";
            }

            if (txtResSSNumero.Text.Trim().Length == 0)
            {
                datosValidados = false;
                mensajeError += " - Número de seguridad social del residente\n";
            }

            if (datosValidados)
                return true;

            MessageBox.Show(mensajeError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }
        private void GuardarDatos()
        {
            // Insertar los datos de la empresa
            string giro = "", sector = "";

            if (rbtnEmpGiroIndustrial.Checked)
                giro = "Industrial";
            if (rbtnEmpGiroServicios.Checked)
                giro = "Servicios";
            if (rbtnEmpGiroOtro.Checked)
                giro = "Otro";

            if (rbtnEmpTipoPublica.Checked)
                sector = "Publico";
            if (rbtnEmpTipoPrivada.Checked)
                sector = "Privado";

            EmpresaDAO.InsertarEmpresa(
                new EmpresaPOJO(txtEmpRFC.Text,
                                txtEmpNombre.Text,
                                giro,
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

            // Actualizar los datos del alumno
            alumno.Domicilio = txtResDomicilio.Text.Trim();
            alumno.Ciudad = txtResCiudad.Text.Trim();
            alumno.Correo = txtResEmail.Text.Trim();
            alumno.Telefono = txtResTelefono.Text.Trim();
            alumno.NumeroSS = txtResSSNumero.Text.Trim();

            if (rbtnResSSIMSS.Checked)
                alumno.TipoSS = "IMSS";
            if (rbtnResSSISSSTE.Checked)
                alumno.TipoSS = "ISSSTE";
            if (rbtnResSSOtro.Checked)
                alumno.TipoSS = "Otro";

            AlumnoDAO.Actualizar(alumno);

            // Registrar la informacion de la residencia
            string modalidad = "";

            if (rbtnProTipoBanco.Checked)
                modalidad = "Banco de proyectos";
            if (rbtnProTipoPropia.Checked)
                modalidad = "Propuesta propia";
            if (rbtnProTipoTrabajador.Checked)
                modalidad = "Trabajador";

            int idResidencia = ResidenciaDAO.InsertarResidencia(
                new ResidenciaPOJO(
                    -1,
                    txtProNombre.Text,
                    modalidad,
                    cmbProPeriodo.SelectedItem.ToString(),
                    DateTime.Now.Year,
                    txtEmpAsesorNombre.Text,
                    txtEmpAsesorPuesto.Text,
                    txtEmpFirmaNombre.Text,
                    txtEmpFirmaPuesto.Text,
                    txtEmpRFC.Text,
                    txtResNoControl.Text
                ));

            // Registrar la solicitud
            SolicitudDAO.InsertarSolicitud(new SolicitudPOJO(-1, txtResNoControl.Text, idResidencia, "PENDIENTE"));

            MessageBox.Show("Solicitud registrada correctamente.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            esEdicion = true;
        }
        private void ModificarDatos()
        {
            // Actualizar los datos de la empresa
            string giro = "", sector = "";

            if (rbtnEmpGiroIndustrial.Checked)
                giro = "Industrial";
            if (rbtnEmpGiroServicios.Checked)
                giro = "Servicios";
            if (rbtnEmpGiroOtro.Checked)
                giro = "Otro";

            if (rbtnEmpTipoPublica.Checked)
                sector = "Publico";
            if (rbtnEmpTipoPrivada.Checked)
                sector = "Privado";

            var empresa = EmpresaDAO.ObtenerEmpresa(txtEmpRFC.Text);
            if (empresa != null)
                EmpresaDAO.ActualizarEmpresa(
                    new EmpresaPOJO(txtEmpRFC.Text,
                                    txtEmpNombre.Text,
                                    giro,
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
            else
                EmpresaDAO.InsertarEmpresa(
                        new EmpresaPOJO(txtEmpRFC.Text,
                                        txtEmpNombre.Text,
                                        giro,
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

            // Actualizar los datos del alumno
            alumno.Domicilio = txtResDomicilio.Text.Trim();
            alumno.Ciudad = txtResCiudad.Text.Trim();
            alumno.Correo = txtResEmail.Text.Trim();
            alumno.Telefono = txtResTelefono.Text.Trim();
            alumno.NumeroSS = txtResSSNumero.Text.Trim();

            if (rbtnResSSIMSS.Checked)
                alumno.TipoSS = "IMSS";
            if (rbtnResSSISSSTE.Checked)
                alumno.TipoSS = "ISSSTE";
            if (rbtnResSSOtro.Checked)
                alumno.TipoSS = "Otro";

            AlumnoDAO.Actualizar(alumno);

            // Actualizar los datos de la residencia
            int idResidencia = SolicitudDAO.ObtenerSolicitud(alumno.Matricula).IdResidencia;

            string modalidad = "";

            if (rbtnProTipoBanco.Checked)
                modalidad = "Banco de proyectos";
            if (rbtnProTipoPropia.Checked)
                modalidad = "Propuesta propia";
            if (rbtnProTipoTrabajador.Checked)
                modalidad = "Trabajador";

            ResidenciaDAO.ActualizarResidencia(
                 new ResidenciaPOJO(
                    idResidencia,
                    txtProNombre.Text,
                    modalidad,
                    cmbProPeriodo.SelectedItem.ToString(),
                    DateTime.Now.Year,
                    txtEmpAsesorNombre.Text,
                    txtEmpAsesorPuesto.Text,
                    txtEmpFirmaNombre.Text,
                    txtEmpFirmaPuesto.Text,
                    txtEmpRFC.Text,
                    txtResNoControl.Text
                ));

            MessageBox.Show("Solicitud actualizada correctamente.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void ImprimirSolicitud()
        {
            if (!ValidarDatos())
                return;

            // Inicializar el cuadro de diálogo
            sfdImpresion.FileName = string.Format("Solicitud_{0}", alumno.Matricula);
            sfdImpresion.Filter = "Archivo de Excel (.xlsx)|*.xlsx";

            DialogResult dr = sfdImpresion.ShowDialog();

            if (dr != DialogResult.OK)
                return;

            bool resultado = SolicitudGenerador.GenerarFormatoDeSolicitud(alumno.Matricula, sfdImpresion.FileName);

            if (resultado)
                MessageBox.Show("Archivo generado corretamente", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Ocurrio un error al generar el archivo. Intente más tarde.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
