using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResidenciasProfesionales.MODEL
{
    /// <summary>
    /// Objeto POJO de empresa.
    /// </summary>
    /// <remarks>
    /// Permite manipular todos los atributos de la empresa a través de un solo 
    /// objeto.
    /// </remarks>
    public class EmpresaPOJO
    {
        // Getters y Setters.
        public String RFC { get; set; }
        public String Nombre { get; set; }
        public String Giro { get; set; }
        public String Sector { get; set; }
        public String Domicilio { get; set; }
        public String Colonia { get; set; }
        public String Ciudad { get; set; }
        public String CP { get; set; }
        public String Telefono { get; set; }
        public String Fax { get; set; }
        public String Mision { get; set; }
        public String Titular { get; set; }
        public String PuestoTit { get; set; }

        // Constructores.
        public EmpresaPOJO() { }

        public EmpresaPOJO(String rfc, String nombre, String giro, String sector, String domicilio, String colonia, String ciudad,
            String cp, String telefono, String fax, String mision, String titular, String puestoTit) {
            RFC = rfc;
            Nombre = nombre;
            Giro = giro;
            Sector = sector;
            Domicilio = domicilio;
            Colonia = colonia;
            Ciudad = ciudad;
            CP = cp;
            Telefono = telefono;
            Fax = fax;
            Mision = mision;
            Titular = titular;
            PuestoTit = puestoTit;
        }
    }
}
