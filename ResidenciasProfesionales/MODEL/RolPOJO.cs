using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResidenciasProfesionales.MODEL
{
    /// <summary>
    /// Objeto POJO de rol.
    /// </summary>
    /// <remarks>
    /// Permite manipular todos los atributos del rol a través de un solo objeto.
    /// </remarks>
    public class RolPOJO
    {
        // Getters y Setters.
        public String IdAlumno { get; set; }
        public String IdDocente { get; set; }
        public String Rol { get; set; }

        // Constructores.
        public RolPOJO() { }
        public RolPOJO(String idAlumno, String idDocente, String rol)
        {
            IdAlumno = idAlumno;
            IdDocente = idDocente;
            Rol = rol;
        }
    }
}