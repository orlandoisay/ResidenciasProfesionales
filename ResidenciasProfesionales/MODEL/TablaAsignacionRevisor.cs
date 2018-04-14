using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResidenciasProfesionales.MODEL
{

    class TablaAsignacionRevisor
    {

        public string NoControl { get; set; }
        public string Alumno { get; set; }
        public string IdAsesor { get; set; }
        public string Asesor { get; set; }
        public string Revisor1 { get; set; }
        public string Revisor2 { get; set; }

        public TablaAsignacionRevisor(MAA datos,string revisor1, string revisor2) {
            NoControl = datos.Matricula;
            Alumno = datos.Alumno;
            Asesor = datos.Asesor;
            Revisor1 = revisor1;
            Revisor2 = revisor2;
            IdAsesor = datos.IdAsesor;
        }

    }

}
