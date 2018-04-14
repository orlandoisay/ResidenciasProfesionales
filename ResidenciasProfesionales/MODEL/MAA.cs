using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResidenciasProfesionales.MODEL
{
    class MAA
    {

        public string Matricula { get; set; }
        public string Alumno { get; set; }
        public string IdAsesor { get; set; }
        public string Asesor { get; set; }

        public MAA(string matricula, string alumno,string idAsesor, string asesor)
        {
            Matricula = matricula;
            Alumno = alumno;
            Asesor = asesor;
            IdAsesor = idAsesor;
        }

    }
}
