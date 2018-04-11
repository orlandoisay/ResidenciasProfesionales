using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResidenciasProfesionales.MODEL
{
    public class CarreraPOJO
    {
        public int ID { get; set; }
        public string Nombre { get; set; }

        public CarreraPOJO() { }
        public CarreraPOJO(int id, string nombre)
        {
            ID = id;
            Nombre = nombre;
        }
    }
}
