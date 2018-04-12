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
    class DictamenDAO
    {
        // Obtiene un solo dictamen, con base en el id de la residencia ingresada como parámetro.
        public static DictamenPOJO ObtenerDictamen(int idResidencia)
        {
            try
            {
                Conexion con = new Conexion();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM dictamen WHERE IdResidencia LIKE @P0");
                cmd.Parameters.AddWithValue("@P0", idResidencia);

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

        // Ingresa la calificación final al dictamen.
        public static void agregarCalificacionFinal(int idResidencia, float calificacion)
        {
            try
            {
                Conexion con = new Conexion();
                MySqlCommand cmd = new MySqlCommand("UPDATE dictamen SET Calificacion=@P0 WHERE IdResidencia=@P1");

                cmd.Parameters.AddWithValue("@P0", calificacion);
                cmd.Parameters.AddWithValue("@P1", idResidencia);

                con.ejecutarSentencia(cmd, false);
            }
            catch (Exception ex)
            {
                return;
            }
            finally
            {
                if (Conexion.conexion != null)
                    Conexion.conexion.Close();
            }
        }

        public static DictamenPOJO DataRowAObjeto(DataRow dr)
        {
            return new DictamenPOJO(
                int.Parse(dr["ID"].ToString()),
                int.Parse(dr["IdResidencia"].ToString()),
                dr["IdDocente"].ToString(),
                dr["Tipo"].ToString(),
                dr["Comentario"].ToString(),
                float.Parse(dr["Calificacion"].ToString()),
                DateTime.Parse(dr["Fecha"].ToString()));
        }
    }
}
