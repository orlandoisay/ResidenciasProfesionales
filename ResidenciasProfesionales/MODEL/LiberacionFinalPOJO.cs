using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResidenciasProfesionales.MODEL
{
    /// <summary>
    /// Objeto POJO de liberación final.
    /// </summary>
    /// <remarks>
    /// Permite manipular todos los atributos de una liberación final 
    /// a través de un solo objeto.
    /// </remarks>
    public class LiberacionFinalPOJO
    {
        // Getters y Setters.
        public String Matricula { get; set; }
        public String NombreAlumno { get; set; }
        public String Proyecto { get; set; }
        public String Empresa { get; set; }
        public String IdEmpresa { get; set; }

        // Constructores.
        public LiberacionFinalPOJO() { }

        public LiberacionFinalPOJO(String matricula, String nombreAlumno, String proyecto, String empresa, String idEmpresa)
        {
            Matricula = matricula;
            NombreAlumno = nombreAlumno;
            Proyecto = proyecto;
            Empresa = empresa;
            IdEmpresa = idEmpresa;
        }
    }
}
