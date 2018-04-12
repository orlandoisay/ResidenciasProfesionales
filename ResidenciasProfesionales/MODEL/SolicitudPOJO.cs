using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResidenciasProfesionales.MODEL
{
    public class SolicitudPOJO
    {
        public int ID { get; set; }
        public String IdAlumno { get; set; }
        public String IdResidencia { get; set; }

        public SolicitudPOJO() { }

        public SolicitudPOJO(int id, String idAlumno, String idResidencia) {
            ID = id;
            IdAlumno = idAlumno;
            IdResidencia = IdResidencia;
        }
    }
}
