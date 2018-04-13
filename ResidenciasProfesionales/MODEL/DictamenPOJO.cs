using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResidenciasProfesionales.MODEL
{
    class DictamenPOJO
    {
        public int ID { get; set; }
        public int IdResidencia { get; set; }
        public String IdDocente { get; set; }
        public String Tipo { get; set; }
        public String Estatus { get; set; }
        public String Comentario { get; set; }
        public int Calificacion { get; set; }
        public DateTime Fecha { get; set; }

        public DictamenPOJO() { }

        public DictamenPOJO(int id, int idResidencia, String idDocente, String tipo, String estatus, 
            String comentario, int calificacion, DateTime fecha) {
            ID = id;
            IdResidencia = idResidencia;
            IdDocente = idDocente;
            Tipo = tipo;
            Estatus = estatus;
            Comentario = comentario;
            Calificacion = calificacion;
            Fecha = fecha;
        }
    }
}
