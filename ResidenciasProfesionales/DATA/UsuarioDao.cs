using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ResidenciasProfesionales.MODEL;
using System.Data;
using MySql.Data.MySqlClient;

namespace ResidenciasProfesionales.DATA
{
    /// <summary>
    /// Objeto de acceso a datos de usuario.
    /// </summary>
    /// <remarks>
    /// Permite acceder a los datos almacenados del usuario.
    /// </remarks>
    class UsuarioDao
    {
        /// <summary>
        /// Permite conocer si el usuario ingresado como parámetro
        /// realmente existe en la base de datos.
        /// </summary>
        /// <param name="usuario"></param>
        /// Representa el nombre del usuario ingresado en el login.
        /// <returns>
        /// Retorna true si el usuario si se encuentra almacenado,
        /// si no es así, retorna false.
        /// </returns>
        public Boolean Existe(Usuario usuario)
        {
            try
            {
                String sentencia = "";
                if (usuario.TipoUsuario == "Alumno")
                {
                    sentencia = "select * from alumno where Matricula =  @P0 and Password =  @P1;";
                }
                else
                {
                    sentencia = "select * from Docente d join rolDocente rd on d.ID = rd.IdDocente where d.Usuario = @P0 and d.Password = @P1 and rd.Rol = @P2;";
                }
                Conexion con = new Conexion();
                MySqlCommand cmd = new MySqlCommand(sentencia);

                cmd.Parameters.AddWithValue("@P0", usuario.Usuario_m);
                cmd.Parameters.AddWithValue("@P1", usuario.Contrasena);
                cmd.Parameters.AddWithValue("@P2", usuario.TipoUsuario);

                DataTable dtProductos = con.ejecutarConsulta(cmd);
                
                if (dtProductos != null && dtProductos.Rows.Count > 0)
                {
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                if (Conexion.conexion != null)
                {
                    Conexion.conexion.Close();
                }
            }
        }

    }
}
