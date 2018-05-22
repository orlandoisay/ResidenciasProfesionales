using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResidenciasProfesionales.MODEL
{
    /// <summary>
    /// Objeto POJO de alumno.
    /// </summary>
    /// <remarks>
    /// Permite manipular todos los atributos del alumno a través de un solo objeto.
    /// </remarks>
    public class AlumnoPOJO
    {
        // Getters y Setters.
        public String Matricula { get; set; }
        public String Password { get; set; }
        public String Nombre { get; set; }
        public String ApellidoP { get; set; }
        public String ApellidoM { get; set; }
        public String Correo { get; set; }
        public String Telefono { get; set; }
        public int Carrera { get; set; }
        public int Semestre { get; set; }
        public String TipoSS { get; set; }
        public String NumeroSS { get; set; }
        public String Estatus { get; set; }
        public String Domicilio { get; set; }
        public String Ciudad { get; set; }

        public String NombreCompleto
        {
            get
            {
                return string.Format("{0} {1} {2}", ApellidoP, ApellidoM, Nombre);
            }
        }

        // Constructores.
        public AlumnoPOJO() { }

        public AlumnoPOJO(String matricula, String password, String nombre, String apellidoP, String apellidoM, String correo,
            String telefono, int carrera, int semestre, String tipoSS, String numeroSS, String estatus, String domicilio, String ciudad) {
            Matricula = matricula;
            Password = password;
            Nombre = nombre;
            ApellidoP = apellidoP;
            ApellidoM = apellidoM;
            Correo = correo;
            Telefono = telefono;
            Carrera = carrera;
            Semestre = semestre;
            TipoSS = tipoSS;
            NumeroSS = numeroSS;
            Estatus = estatus;
            Domicilio = domicilio;
            Ciudad = ciudad;
        }
    }
}
