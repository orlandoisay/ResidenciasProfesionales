using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResidenciasProfesionales.MODEL
{
    public class TablaResumenPOJO
    {
        public String Matricula { get; set; }
        public String NombreAlumno { get; set; }
        public String DictamenFinal { get; set; }
        public int Calificacion { get; set; }
        public String Asesor { get; set; }
        public String DictamenAsesor { get; set; }
        public String ComentarioAsesor { get; set; }
        public String Revisor1 { get; set; }
        public String DictamenRevisor1 { get; set; }
        public String ComentarioRevisor1 { get; set; }
        public String Revisor2 { get; set; }
        public String DictamenRevisor2 { get; set; }
        public String ComentarioRevisor2{ get; set; }
        public String Proyecto { get; set; }
        public String Empresa { get; set; }

        public TablaResumenPOJO() { }

        public TablaResumenPOJO(String matricula, String nombreAlumno, String dictamenFinal, int calificacion, String asesor,
            String dictamenAsesor, String comentarioAsesor, String revisor1, String dictamenRevisor1, String comentarioReevisor1,
            String revisor2, String dictamenRevisor2, String comentarioReevisor2, String proyecto, String empresa) {
            Matricula = matricula;
            NombreAlumno = nombreAlumno;
            DictamenFinal = dictamenFinal;
            Calificacion = calificacion;
            Asesor = asesor;
            DictamenAsesor = dictamenAsesor;
            ComentarioAsesor = comentarioAsesor;
            Revisor1 = revisor1;
            DictamenRevisor1 = dictamenRevisor1;
            ComentarioRevisor1 = comentarioReevisor1;
            Revisor2 = revisor2;
            DictamenRevisor2 = dictamenRevisor2;
            ComentarioRevisor2 = comentarioReevisor2;
            Proyecto = proyecto;
            Empresa = empresa;
        }
    }
}
