using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResidenciasProfesionales.MODEL
{
    public class EmpresaPOJO
    {
        public String RFC { get; set; }
        public String Nombre { get; set; }
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

        public EmpresaPOJO() { }

        public EmpresaPOJO(String rfc, String nombre, String sector, String domicilio, String colonia, String ciudad,
            String cp, String telefono, String fax, String mision, String titular, String puestoTit) {
            RFC = rfc;
            Nombre = nombre;
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
