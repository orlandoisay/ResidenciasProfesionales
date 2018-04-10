using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ResidenciasProfesionales.MODEL
{
    class Usuario
    {
        public string Usuario_m { get; set; }
        public string Contrasena { get; set; }
        public string TipoUsuario { get; set; }

        public Usuario(string usuario,string contrasena,string tipoUsuario) {
            Usuario_m = usuario;
            Contrasena = contrasena;
            TipoUsuario = tipoUsuario;
        }


    }
}
