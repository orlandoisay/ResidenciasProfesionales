using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace ResidenciasProfesionales.DATA
{
    public class SolicitudGenerador
    {
        public static bool GenerarFormatoDeSolicitud(String matricula, String ruta)
        {
            // Obtener informacion de la solicitud
            var alumno = AlumnoDAO.ObtenerAlumno(matricula);
            var solicitud = SolicitudDAO.ObtenerSolicitud(matricula);
            var residencia = ResidenciaDAO.ObtenerResidencia(solicitud.IdResidencia);
            var empresa = EmpresaDAO.ObtenerEmpresa(residencia.IdEmpresa);

            // Obtener la ruta del archivo de plantilla
            var rutaPlantilla = Path.Combine(System.IO.Path.GetFullPath(@"..\..\"), "Resources", "Plantilla.xlsx");
            var listaDatos = new List<DatoCelda>();

            // Fecha
            listaDatos.Add(new DatoCelda(6, 17, String.Format("{0:00}/{1:00}/{2}", DateTime.Now.Day,
                                                                                   DateTime.Now.Month,
                                                                                   DateTime.Now.Year)));

            // Nombre del proyecto
            listaDatos.Add(new DatoCelda(11, 10, residencia.NombreProyec));

            // Opcion elegida
            if (residencia.Modalidad == "Banco de proyectos")
                    listaDatos.Add(new DatoCelda(14, 13, "X"));

            if (residencia.Modalidad == "Propuesta propia")
                    listaDatos.Add(new DatoCelda(14, 20, "X"));

            if (residencia.Modalidad == "Trabajador")
                    listaDatos.Add(new DatoCelda(14, 26, "X"));
            
            // Periodo proyectado
            listaDatos.Add(new DatoCelda(17, 10, String.Format("{0} {1}", residencia.Periodo, residencia.Anio)));

            // Nombre de la empresa
            listaDatos.Add(new DatoCelda(22, 4, empresa.Nombre));

            // Giro de la empresa
            listaDatos.Add(new DatoCelda(24, 4, String.Format("Industrial ( {0} ) Servicios ( {1} ) Otro  ( {2} )",
                                                              empresa.Giro == "Industrial"  ? "X" : " ",
                                                              empresa.Giro == "Servicios"   ? "X" : " ",
                                                              empresa.Giro == "Otro"        ? "X" : " ")));
            
            // RFC de la empresa
            listaDatos.Add(new DatoCelda(24, 19, empresa.RFC));

            // Sector de la empresa
            listaDatos.Add(new DatoCelda(25, 4, String.Format("Pública ( {0} ) Privada( {1} )",
                                                              empresa.Sector == "Publico" ? "X" : " ",
                                                              empresa.Sector == "Privado" ? "X" : " ")));

            // Domicilio de la empresa
            listaDatos.Add(new DatoCelda(26, 4, empresa.Domicilio));

            // Colonia de la empresa
            listaDatos.Add(new DatoCelda(28, 4, empresa.Colonia));

            // CP de la empresa
            listaDatos.Add(new DatoCelda(28, 15, empresa.CP));

            // Fax de la empresa
            listaDatos.Add(new DatoCelda(28, 21, empresa.Fax));

            // Mision de la empresa
            listaDatos.Add(new DatoCelda(30, 4, empresa.Mision));

            // Nombre del titular de la empresa
            listaDatos.Add(new DatoCelda(37, 6, empresa.Titular));

            // Puesto del titular de la empresa
            listaDatos.Add(new DatoCelda(37, 19, empresa.PuestoTit));

            // Nombre del asesor de la empresa
            listaDatos.Add(new DatoCelda(39, 6, residencia.AsesorExt));

            // Puesto del asesor de la empresa
            listaDatos.Add(new DatoCelda(39, 19, residencia.PuestoAsesor));

            // Nombre del responsable de la empresa
            listaDatos.Add(new DatoCelda(41, 9, residencia.Responsable));

            // Puesto del responsable de la empresa
            listaDatos.Add(new DatoCelda(41, 19, residencia.PuestoResp));

            // Nombre del residente
            listaDatos.Add(new DatoCelda(51, 4, alumno.NombreCompleto));

            // Carrera del residente
            listaDatos.Add(new DatoCelda(53, 4, CarreraDAO.ObtenerUno(alumno.Carrera).Nombre));

            // Matricula del residente
            listaDatos.Add(new DatoCelda(53, 19, alumno.Matricula));

            // Domicilio del residente
            listaDatos.Add(new DatoCelda(55, 4, alumno.Domicilio));

            // Correo del residente
            listaDatos.Add(new DatoCelda(57, 4, alumno.Correo));

            // Tipo de SS del residente
            listaDatos.Add(new DatoCelda(57, 17, String.Format("IMSS ( {0} ) ISSSTE( {1} ) Otro( {2} )",
                                                              alumno.TipoSS == "IMSS"   ? "X" : " ",
                                                              alumno.TipoSS == "ISSSTE" ? "X" : " ",
                                                              alumno.TipoSS == "Otro"   ? "X" : " ")));

            // Numero de SS del residente
            listaDatos.Add(new DatoCelda(58, 17, alumno.NumeroSS));

            // Ciudad del residente
            listaDatos.Add(new DatoCelda(59, 4, alumno.Ciudad));

            // Telefono del residente
            listaDatos.Add(new DatoCelda(59, 17, alumno.Telefono));

            return LlenarPlantillaConDatos(ruta, rutaPlantilla, listaDatos);
        }

        public static bool LlenarPlantillaConDatos(String rutaFinal, String rutaPlantilla, List<DatoCelda> listaDatos)
        {
            // Iniciar Excel
            Excel.Application excel = new Excel.Application();

            try
            {
                // Cargar la plantilla de Excel                
                Excel.Workbook book = excel.Workbooks.Open(rutaPlantilla);
                Excel.Worksheet sheet = excel.ActiveSheet as Excel.Worksheet;

                // Carga de datos al archivo
                foreach (DatoCelda dc in listaDatos)
                    sheet.Cells[dc.Fila, dc.Columna] = dc.Valor;

                sheet.SaveAs(rutaFinal);
                

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }   
            finally
            {
                excel.Quit();
            }         
        }
    }

    public class DatoCelda
    {
        public int Fila { get; set; }
        public int Columna { get; set; }
        public String Valor { get; set; }

        public DatoCelda() { }
        public DatoCelda(int fila, int columna, String valor)
        {
            Fila = fila;
            Columna = columna;
            Valor = valor;
        }
    }
}
