using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResidenciasProfesionales.MODEL
{
    public class RolPOJO
    {
        public String IdAlumno { get; set; }
        public String IdDocente { get; set; }
        public String Rol { get; set; }

        public RolPOJO() { }
        public RolPOJO(String idAlumno, String idDocente, String rol)
        {
            IdAlumno = idAlumno;
            IdDocente = idDocente;
            Rol = rol;
        }
    }
}
