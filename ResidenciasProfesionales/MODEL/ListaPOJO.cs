﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResidenciasProfesionales.MODEL
{
    public class ListaPOJO
    {
        public String Matricula { get; set; }
        public String NombreAlumno { get; set; }
        public String AsesorInt { get; set; }
        public String AsesorExt { get; set; }
        public String Empresa { get; set; }
        public String Proyecto { get; set; }
        public String TelEmpresa { get; set; }
        public String TelAlumno { get; set; }
        public String CorreoAlumno { get; set; }
        public String CorreoAsesorInt { get; set; }

        public ListaPOJO() { }

        public ListaPOJO(String matricula, String nombreAlumno, String asesorInt, String asesorExt, String empresa,
            String proyecto, String telEmpresa, String telAlumno, String correoAlumno, String correoAsesorInt) {
            Matricula = matricula;
            NombreAlumno = nombreAlumno;
            AsesorInt = asesorInt;
            AsesorExt = asesorExt;
            Empresa = empresa;
            Proyecto = proyecto;
            TelEmpresa = telEmpresa;
            TelAlumno = telAlumno;
            CorreoAlumno = correoAlumno;
            CorreoAsesorInt = correoAsesorInt;
        }
    }
}
