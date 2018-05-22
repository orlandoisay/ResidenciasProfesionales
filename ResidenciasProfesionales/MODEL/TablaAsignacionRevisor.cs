using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResidenciasProfesionales.MODEL
{
    /// <summary>
    /// Objeto POJO de tabla asignación revisor.
    /// </summary>
    /// <remarks>
    /// Permite manipular todos los atributos de tabla asignación revisor
    /// a través de un solo objeto.
    /// </remarks>
    class TablaAsignacionRevisor
    {
        // Getters y Setters.
        public string NoControl { get; set; }
        public string Alumno { get; set; }
        public string IdAsesor { get; set; }
        public string Asesor { get; set; }
        public string Revisor1 { get; set; }
        public string Revisor2 { get; set; }

        // Constructor
        public TablaAsignacionRevisor(MAA datos,string revisor1, string revisor2) {
            NoControl = datos.Matricula;
            Alumno = datos.Alumno;
            Asesor = datos.Asesor;
            Revisor1 = revisor1;
            Revisor2 = revisor2;
            IdAsesor = datos.IdAsesor;
        }
    }
}
