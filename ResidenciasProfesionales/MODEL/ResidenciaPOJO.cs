using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResidenciasProfesionales.MODEL
{
    /// <summary>
    /// Objeto POJO de residencia.
    /// </summary>
    /// <remarks>
    /// Permite manipular todos los atributos de la residencia a través de un solo 
    /// objeto.
    /// </remarks>
    public class ResidenciaPOJO
    {
        // Getters y Setters.
        public int ID { get; set; }
        public String NombreProyec { get; set; }
        public String Modalidad { get; set; }
        public String Periodo { get; set; }
        public int Anio { get; set; }
        public String AsesorExt { get; set; }
        public String PuestoAsesor { get; set; }
        public String Responsable { get; set; }
        public String PuestoResp { get; set; }
        public String IdEmpresa { get; set; }
        public String IdAlumno { get; set; }

        // Constructores.
        public ResidenciaPOJO() { }

        public ResidenciaPOJO(int id, String nombreproyec, String modalidad, String periodo, int anio, String asesorExt,
            String puestoAsesor, String responsable, String puestoResp, String idEmpresa, String idAlumno) {
            ID = id;
            NombreProyec = nombreproyec;
            Modalidad = modalidad;
            Periodo = periodo;
            Anio = anio;
            AsesorExt = asesorExt;
            PuestoAsesor = puestoAsesor;
            Responsable = responsable;
            PuestoResp = puestoResp;
            IdEmpresa = idEmpresa;
            IdAlumno = idAlumno;
        }
    }
}