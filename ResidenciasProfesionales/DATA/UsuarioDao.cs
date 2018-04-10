using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ResidenciasProfesionales.MODEL;
using System.Data;
using MySql.Data.MySqlClient;

namespace ResidenciasProfesionales.DATA
{
    class UsuarioDao
    {
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
                    sentencia = "";
                }
                Conexion con = new Conexion();
                MySqlCommand cmd = new MySqlCommand(sentencia);

                cmd.Parameters.AddWithValue("@P0", usuario.Usuario_m);
                cmd.Parameters.AddWithValue("@P1", usuario.Contrasena);
                cmd.Parameters.AddWithValue("@P2", usuario.TipoUsuario);

                DataTable dtProductos = con.ejecutarConsulta(cmd);

                //Verificar si la consulta regresó resultados
                // para llenar el objeto
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
                //Solo intentar cerrar la conexión cuando si se encuentra abierta
                if (Conexion.conexion != null)
                {
                    Conexion.conexion.Close();
                }
            }
        }

    }
}
