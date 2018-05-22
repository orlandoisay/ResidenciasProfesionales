using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResidenciasProfesionales.MODEL
{
    /// <summary>
    /// Objeto POJO de solicitud.
    /// </summary>
    /// <remarks>
    /// Permite manipular todos los atributos de la solicitud a través de un solo 
    /// objeto.
    /// </remarks>
    public class SolicitudPOJO
    {
        // Getters y Setters.
        public int ID { get; set; }
        public String IdAlumno { get; set; }
        public int IdResidencia { get; set; }
        public String Estatus { get; set; }

        // Constructores.
        public SolicitudPOJO() { }

        public SolicitudPOJO(int id, String idAlumno,int idResidencia, String estatus) {
            ID = id;
            IdAlumno = idAlumno;
            IdResidencia = idResidencia;
            Estatus = estatus;
        }
    }
}
