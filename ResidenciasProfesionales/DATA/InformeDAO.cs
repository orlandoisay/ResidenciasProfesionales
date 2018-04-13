using ResidenciasProfesionales.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResidenciasProfesionales.DATA
{
    public class InformeDAO
    {
        /// <summary>
        /// Obtiene la lista de informes por periodo.
        /// </summary>
        /// <param name="anio"></param>
        /// <param name="periodo"></param>
        /// <param name="aprobados"></param>
        /// <returns></returns>
        public static List<InformePOJO> ObtenerInformesPorPeriodo(int anio, string periodo, int idDocente, bool aprobados)
        {
            throw new NotImplementedException();
        }
    }
}
