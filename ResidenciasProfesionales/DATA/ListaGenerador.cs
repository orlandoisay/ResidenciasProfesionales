using ResidenciasProfesionales.DATA;
using ResidenciasProfesionales.MODEL;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ResidenciasProfesionales.DATA
{
    /// <summary>
    /// Clase auxiliar en la generación del archivo Excel.
    /// </summary>
    /// <remarks>
    /// Ubica la plantilla encargada de darle formato a la información
    /// sobre la lista de residentes.
    /// </remarks>
    public class ListaGenerador
    {
        public static bool GenerarFormatoDeReporte(List<ListaPOJO> elementos, String ruta)
        {
            var rutaPlantilla = Path.Combine(System.IO.Path.GetFullPath(@"..\..\"), "Resources", "ListaResidentes.xlsx");

            var listaDatos = new List<DatoCelda>();

            for (int i = 0; i < elementos.Count; i++)
            {
                listaDatos.Add(new DatoCelda(i + 2, 1, i+""));
                listaDatos.Add(new DatoCelda(i + 2, 2, "S"));
                String n = i + "";
                while (n.Length < 3)
                    n = "0" + n; 
                listaDatos.Add(new DatoCelda(i + 2, 3, n));
                listaDatos.Add(new DatoCelda(i + 2, 4, elementos[i].Matricula));
                listaDatos.Add(new DatoCelda(i + 2, 5, elementos[i].NombreAlumno));
                listaDatos.Add(new DatoCelda(i + 2, 6, elementos[i].AsesorInt));
                listaDatos.Add(new DatoCelda(i + 2, 7, elementos[i].AsesorExt));
                listaDatos.Add(new DatoCelda(i + 2, 8, elementos[i].Empresa));
                listaDatos.Add(new DatoCelda(i + 2, 9, elementos[i].Proyecto));
                listaDatos.Add(new DatoCelda(i + 2, 10, elementos[i].TelEmpresa));
                listaDatos.Add(new DatoCelda(i + 2, 11, elementos[i].TelAlumno));
                listaDatos.Add(new DatoCelda(i + 2, 12, elementos[i].CorreoAlumno));
                listaDatos.Add(new DatoCelda(i + 2, 13, elementos[i].CorreoAsesorInt));
            }
            return ExcelGenerador.LlenarPlantillaConDatos(ruta, rutaPlantilla, listaDatos);
        }
    }
}
