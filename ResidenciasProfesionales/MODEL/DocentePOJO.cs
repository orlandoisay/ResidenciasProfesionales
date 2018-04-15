using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResidenciasProfesionales.MODEL
{
    public class DocentePOJO
    {
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

        public String NombreCompleto
        {
            get
            {
                return string.Format("{0} {1} {2}", ApellidoP, ApellidoM, Nombre);
            }
        }

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
    }
}
