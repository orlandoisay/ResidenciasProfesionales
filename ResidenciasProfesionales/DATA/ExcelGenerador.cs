using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;

namespace ResidenciasProfesionales.DATA
{
    public class ExcelGenerador
    {
        /// <summary>
        /// Toma una plantilla de Excel y una serie de cambios a realizar 
        /// sobre dicho documento y genera un archivo nuevo con las modificiones
        /// especificadas.
        /// </summary>
        /// <param name="rutaFinal">Ruta donde se almacenará el archivo generado</param>
        /// <param name="rutaPlantilla">Ruta donde se encuentra la plantilla a usar</param>
        /// <param name="listaDatos">Lista de cambios a realizar sobre las celdas de la plantilla</param>
        /// <returns>Retorna un booleano que indica si la creación se realizó con éxito.</returns>
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
                Console.WriteLine(ex.Message);
                return false;
            }
            finally
            {
                excel.Quit();
            }
        }
    }

    /// <summary>
    /// Representa un dato que debe ingresarse en la
    /// celda especificada.
    /// </summary>
    public class DatoCelda
    {
        public int Fila { get; set; }
        public int Columna { get; set; }
        public String Valor { get; set; }

        /// <summary>
        /// Representa un dato que debe ingresarse en la
        /// celda especificada a través de las fila y
        /// columna indicadas.
        /// </summary>
        /// <param name="fila"></param>
        /// <param name="columna"></param>
        /// <param name="valor"></param>
        public DatoCelda(int fila, int columna, String valor)
        {
            Fila = fila;
            Columna = columna;
            Valor = valor;
        }
    }
}
