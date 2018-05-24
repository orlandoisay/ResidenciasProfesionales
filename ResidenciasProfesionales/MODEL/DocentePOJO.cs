using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResidenciasProfesionales.MODEL
{
    /// <summary>
    /// Objeto POJO de docente.
    /// </summary>
    /// <remarks>
    /// Permite manipular todos los atributos del docente a través de un solo objeto.
    /// </remarks>
    public class DocentePOJO
    {
        // Getters y Setters.
        public String ID { get; set; }
        public String Nombre { get; set; }
        public String ApellidoP { get; set; }
        public String ApellidoM { get; set; }
        public String Correo { get; set; }
        public String Telefono { get; set; }
        public int Carrera { get; set; }
        public String Usuario { get; set; }
        public String Password { get; set; }
        public String Estatus { get; set; }
        public String Carga { get; set; }
        public string boleana { get; set; }

        public String NombreCompleto
        {
            get
            {
                return string.Format("{0} {1} {2}", ApellidoP, ApellidoM, Nombre);
            }
        }

        // Constructores.
        public DocentePOJO() { }

        public DocentePOJO(String id, String nombre, String apellidoP, String apellidoM, String correo, String telefono,
            int carrera, String usuario, String password, String estatus) {
            ID = id;
            Nombre = nombre;
            ApellidoP = apellidoP;
            ApellidoM = apellidoM;
            Correo = correo;
            Telefono = telefono;
            Carrera = carrera;
            Usuario = usuario;
            Password = password;
            Estatus = estatus;
        }
        public DocentePOJO(String id, String nombre, String apellidoP, String apellidoM, String correo, String telefono,
            int carrera,String estatus, string carga)
        {
            ID = id;
            Nombre = nombre;
            ApellidoP = apellidoP;
            ApellidoM = apellidoM;
            Correo = correo;
            Telefono = telefono;
            Carrera = carrera;
            Estatus = estatus;
            Carga = carga;
        }
    }
}
