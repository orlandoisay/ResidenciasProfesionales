using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResidenciasProfesionales.MODEL
{
    /// <summary>
    /// Objeto POJO de carrera.
    /// </summary>
    /// <remarks>
    /// Permite manipular todos los atributos de la carrera a través de un solo objeto.
    /// </remarks>
    public class CarreraPOJO
    {
        // Getters y Setters.
        public int ID { get; set; }
        public string Nombre { get; set; }

        // Constructores.
        public CarreraPOJO() { }
        public CarreraPOJO(int id, string nombre)
        {
            ID = id;
            Nombre = nombre;
        }
    }
}