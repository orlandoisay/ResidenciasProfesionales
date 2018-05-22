using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResidenciasProfesionales.MODEL
{
    /// <summary>
    /// Objeto POJO de entrega.
    /// </summary>
    /// <remarks>
    /// Permite manipular todos los atributos de una entrega a través de un solo 
    /// objeto.
    /// </remarks>
    public class EntregaPOJO
    {
        // Getters y Setters.
        public String IdAlumno { get; set; }
        public int IdDocumento { get; set; }
        public String Estado { get; set; }

        // Constructores.
        public EntregaPOJO() { }

        public EntregaPOJO(String idAlumno, int idDocumento, String estado) {
            IdAlumno = idAlumno;
            IdDocumento = idDocumento;
            Estado = estado;
        }
    }
}
