﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResidenciasProfesionales.MODEL
{
    public class AlumnoPOJO
    {
        public String Matricula { get; set; }
        public String Password { get; set; }
        public String Nombre { get; set; }
        public String ApellidoP { get; set; }
        public String ApellidoM { get; set; }
        public String Correo { get; set; }
        public String Telefono { get; set; }
        public int Carrera { get; set; }
        public int Semestre { get; set; }
        public String TipoSS { get; set; }
        public String NumeroSS { get; set; }
        public String Estatus { get; set; }
        public String Domicilio { get; set; }
        public String Ciudad { get; set; }

        public String NombreCompleto
        {
            get
            {
                return string.Format("{0} {1}, {2}", ApellidoP, ApellidoM, Nombre);
            }
        }

        public AlumnoPOJO() { }

        public AlumnoPOJO(String matricula, String password, String nombre, String apellidoP, String apellidoM, String correo,
            String telefono, int carrera, int semestre, String tipoSS, String numeroSS, String estatus, String domicilio, String ciudad) {
            Matricula = matricula;
            Password = password;
            Nombre = nombre;
            ApellidoP = apellidoP;
            ApellidoM = apellidoM;
            Correo = correo;
            Telefono = telefono;
            Carrera = carrera;
            Semestre = semestre;
            TipoSS = tipoSS;
            NumeroSS = numeroSS;
            Estatus = estatus;
            Domicilio = domicilio;
            Ciudad = ciudad;
        }

        public AlumnoPOJO(String matricula, String password, String nombre, String apellidoP, String apellidoM, String correo,
            String telefono, int carrera, int semestre, String estatus) {
            Matricula = matricula;
            Password = password;
            Nombre = nombre;
            ApellidoP = apellidoP;
            ApellidoM = apellidoM;
            Correo = correo;
            Telefono = telefono;
            Carrera = carrera;
            Semestre = semestre;
            Estatus = estatus;
        }
    }
}
