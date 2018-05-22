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
    /// sobre los reportes.
    /// </remarks>
    public class ResumenGenerrador
    {
        public static bool GenerarFormatoDeReporte(List<TablaResumenPOJO> elementos, String ruta)
        {
            var rutaPlantilla = Path.Combine(System.IO.Path.GetFullPath(@"..\..\"), "Resources", "PlantillaReporte.xlsx");

            var listaDatos = new List<DatoCelda>();

            for (int i = 0; i < elementos.Count; i++)
            {
                listaDatos.Add(new DatoCelda(i + 2, 1, elementos[i].Matricula));
                listaDatos.Add(new DatoCelda(i + 2, 2, elementos[i].NombreAlumno));
                listaDatos.Add(new DatoCelda(i + 2, 3, elementos[i].DictamenFinal));
                listaDatos.Add(new DatoCelda(i + 2, 4, elementos[i].Calificacion + ""));
                listaDatos.Add(new DatoCelda(i + 2, 5, elementos[i].Asesor));
                listaDatos.Add(new DatoCelda(i + 2, 6, elementos[i].DictamenAsesor));
                listaDatos.Add(new DatoCelda(i + 2, 7, elementos[i].ComentarioAsesor));
                listaDatos.Add(new DatoCelda(i + 2, 8, elementos[i].Revisor1));
                listaDatos.Add(new DatoCelda(i + 2, 9, elementos[i].DictamenRevisor1));
                listaDatos.Add(new DatoCelda(i + 2, 10, elementos[i].ComentarioRevisor1));
                listaDatos.Add(new DatoCelda(i + 2, 11, elementos[i].Revisor2));
                listaDatos.Add(new DatoCelda(i + 2, 12, elementos[i].DictamenRevisor2));
                listaDatos.Add(new DatoCelda(i + 2, 13, elementos[i].ComentarioRevisor2));
                listaDatos.Add(new DatoCelda(i + 2, 14, elementos[i].Proyecto));
                listaDatos.Add(new DatoCelda(i + 2, 15, elementos[i].Empresa));
            }

            return ExcelGenerador.LlenarPlantillaConDatos(ruta, rutaPlantilla, listaDatos);
        }
    }
}
