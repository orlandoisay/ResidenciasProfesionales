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
    public class ListaGenerador
    {
        public static bool GenerarFormatoDeReporte(List<ListaPOJO> elementos, String ruta)
        {
            // Obtener la ruta del archivo de plantilla
            var rutaPlantilla = Path.Combine(System.IO.Path.GetFullPath(@"..\..\"), "Resources", "ListaResidentes.xlsx");

            var listaDatos = new List<DatoCelda>();

            for (int i = 0; i < elementos.Count; i++)
            {
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
