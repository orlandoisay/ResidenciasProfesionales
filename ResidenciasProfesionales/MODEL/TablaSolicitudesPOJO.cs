using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResidenciasProfesionales.MODEL
{
    public class TablaSolicitudes
    {
        public String Matricula { get; set; }
        public String NombreAlumno { get; set; }
        public int Semestre { get; set; }
        public String NombreProyecto { get; set; }
        public String Modalidad { get; set; }
        public String Periodo { get; set; }
        public String NombreEmpresa { get; set; }

        public TablaSolicitudes() { }

        public TablaSolicitudes(String matricula, String nombreAlumno, int semestre, String nombreProyecto, String modalidad,
            String periodo, String nombreEmpresa) {
            Matricula = matricula;
            NombreAlumno = nombreAlumno;
            Semestre = semestre;
            NombreProyecto = nombreProyecto;
            Modalidad = modalidad;
            Periodo = periodo;
            NombreEmpresa = nombreEmpresa;
        }
    }
}
