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
    public class EntregaDAO
    {
        public static List<EntregaPOJO> ObtenerTodos()
        {
            try
            {
                var list = new List<EntregaPOJO>();

                Conexion con = new Conexion();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM entregaDocumento");

                DataTable dt = con.ejecutarConsulta(cmd);

                foreach (DataRow dr in dt.Rows)
                    list.Add(DataRowAObjeto(dr));

                return list;
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
        public static EntregaPOJO ObtenerEntrega(String idAlumno, int idDocumento)
        {
            try
            {
                Conexion con = new Conexion();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM entregaDocumento WHERE idAlumno like @P0 and idDocumento = @P1");
                cmd.Parameters.AddWithValue("@P0", idAlumno);
                cmd.Parameters.AddWithValue("@P1", idDocumento);

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

        public static List<EntregaPOJO> ObtenerDocumentosPendientes()
        {
            try
            {
                var list = new List<EntregaPOJO>();

                Conexion con = new Conexion();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM entregaDocumento WHERE estatus like 'Pendiente'");

                DataTable dt = con.ejecutarConsulta(cmd);

                foreach (DataRow dr in dt.Rows)
                    list.Add(DataRowAObjeto(dr));

                return list;
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

        public static EntregaPOJO DataRowAObjeto(DataRow dr)
        {
            return new EntregaPOJO(
                dr["idAlumno"].ToString(),
                int.Parse(dr["idDocumento"].ToString()),
                dr["Estatus"].ToString()
            );
        }
    }
}
