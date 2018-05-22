using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ResidenciasProfesionales.MODEL
{
    /// <summary>
    /// Objeto POJO de usuario.
    /// </summary>
    /// <remarks>
    /// Permite manipular todos los atributos del usuario a través de un solo 
    /// objeto.
    /// </remarks>
    class Usuario
    {
        // Getters y Setters.
        public string Usuario_m { get; set; }
        public string Contrasena { get; set; }
        public string TipoUsuario { get; set; }

        // Constructor.
        public Usuario(string usuario,string contrasena,string tipoUsuario) {
            Usuario_m = usuario;
            Contrasena = contrasena;
            TipoUsuario = tipoUsuario;
        }
    }
}