using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResidenciasProfesionales.MODEL
{
    /// <summary>
    /// Objeto POJO de Asesor.
    /// </summary>
    /// <remarks>
    /// Permite manipular todos los atributos del asesor a través de un solo objeto.
    /// </remarks>
    class Asesor
    {
        // Getters y Setters.
        public string Id { get; set; }
        public string Nombre { get; set; }
        public string ApellidoP { get; set; }
        public string ApellidoM { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }
        public string Carrera { get; set; }
        public string Estatus { get; set; }
        public String NombreCompleto
        {
            get
            {
                return string.Format("{0} {1}, {2}", ApellidoP, ApellidoM, Nombre);
            }
        }

        // Constructores.
        public Asesor(string id, string nombre, string apellidoP, string apellidoM, string correo,
       string telefono, string carrera, string estatus)
        {
            Id = id;
            Nombre = nombre;
            ApellidoP = apellidoP;
            ApellidoM = apellidoM;
            Correo = correo;
            Telefono = telefono;
            Carrera = carrera;
            Estatus = estatus;
        }
    }
}
