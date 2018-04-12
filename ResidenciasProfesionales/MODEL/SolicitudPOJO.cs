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
        public int IdResidencia { get; set; }

        public SolicitudPOJO() { }

        public SolicitudPOJO(int id, String idAlumno,int idResidencia) {
            ID = id;
            IdAlumno = idAlumno;
            IdResidencia = IdResidencia;
        }
    }
}
