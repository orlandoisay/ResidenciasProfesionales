using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResidenciasProfesionales.MODEL
{
    public class EntregaPOJO
    {
        public String IdAlumno { get; set; }
        public int IdDocumento { get; set; }
        public String Estado { get; set; }

        public EntregaPOJO() { }

        public EntregaPOJO(String idAlumno, int idDocumento, String estado) {
            IdAlumno = idAlumno;
            IdDocumento = idDocumento;
            Estado = estado;
        }
    }
}
