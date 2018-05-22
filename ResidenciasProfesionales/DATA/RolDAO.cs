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
        /// <summary>
        /// Obtiene el rol que existe entre el alumno y el docente,
        /// ambos ingresados como parámetro.
        /// </summary>
        /// <param name="idAlumno"></param>
        /// Identificador del alumno.
        /// <param name="idDocente"></param>
        /// Identificador del docente.
        /// <returns>
        /// Retorna el rol ubicado por los identificadores descritos.
        /// </returns>
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

        /// <summary>
        /// Busca en la base de datos si un rol en especifico
        /// existe entre el alumno y el asesor, ambos ingresados
        /// como parámetro.
        /// </summary>
        /// <param name="idAlumno"></param>
        /// Identificador del alumno.
        /// <param name="idDocente"></param>
        /// Identificador del docente.
        /// <param name="rol"></param>
        /// Contiene el tipo de rol.
        /// <returns>
        /// Retorna true si el rol existe, de lo contrario retorna false.
        /// </returns>
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

        /// <summary>
        /// Construye un rol con los datos ingresados como parámetro.
        /// </summary>
        /// <param name="dr"></param>
        /// Registro de datos pertenecientes al rol.
        /// <returns>
        /// Retorna el rol creado.
        /// </returns>
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
