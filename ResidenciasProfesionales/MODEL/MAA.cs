using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResidenciasProfesionales.MODEL
{
    /// <summary>
    /// Objeto POJO de MAA.
    /// </summary>
    /// <remarks>
    /// Permite manipular todos los atributos de MAA a través de un solo objeto.
    /// </remarks>
    class MAA
    {
        // Getters y Setters.
        public string Matricula { get; set; }
        public string Alumno { get; set; }
        public string IdAsesor { get; set; }
        public string Asesor { get; set; }

        // Constructores.
        public MAA(string matricula, string alumno,string idAsesor, string asesor)
        {
            Matricula = matricula;
            Alumno = alumno;
            Asesor = asesor;
            IdAsesor = idAsesor;
        }

    }
}
