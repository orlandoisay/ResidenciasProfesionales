using MySql.Data.MySqlClient;
using ResidenciasProfesionales.MODEL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResidenciasProfesionales.DATA
{
    public class RolDAO
    {
        public static RolPOJO ObtenerRol(String idAlumno, String idDocente)
        {
            try
            {
                Conexion con = new Conexion();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM rolDocente WHERE IdAlumno LIKE @P0 AND IdDocente LIKE @P1");
                cmd.Parameters.AddWithValue("@P0", idAlumno);
                cmd.Parameters.AddWithValue("@P1", idDocente);

                DataTable dt = con.ejecutarConsulta(cmd);

                if (dt.Rows.Count != 1)
                    return null;

                return DataRowAObjeto(dt.Rows[0]);
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                if (Conexion.conexion != null)
                    Conexion.conexion.Close();
            }
        }
        public static bool ExisteRol(String idAlumno, String idDocente, String rol)
        {
            try
            {
                Conexion con = new Conexion();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM rolDocente WHERE IdAlumno LIKE @P0 AND IdDocente LIKE @P1 AND Rol LIKE @P2");
                cmd.Parameters.AddWithValue("@P0", idAlumno);
                cmd.Parameters.AddWithValue("@P1", idDocente);
                cmd.Parameters.AddWithValue("@P2", rol);

                DataTable dt = con.ejecutarConsulta(cmd);

                return dt.Rows.Count > 0;
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                if (Conexion.conexion != null)
                    Conexion.conexion.Close();
            }
        }

        public static RolPOJO DataRowAObjeto(DataRow dr)
        {
            return new RolPOJO(
                dr["IdAlumno"].ToString(),
                dr["IdDocente"].ToString(),
                dr["Rol"].ToString()
            );
        }
    }
}
