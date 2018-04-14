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
    public class ResidenciaDAO
    {
        public static ResidenciaPOJO ObtenerResidencia(int id)
        {
            try
            {
                Conexion con = new Conexion();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM infoResidencia WHERE id = @P0");
                cmd.Parameters.AddWithValue("@P0", id);

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

        public static ResidenciaPOJO DataRowAObjeto(DataRow dr)
        {
            return new ResidenciaPOJO(
                int.Parse(dr["ID"].ToString()),
                dr["NombreProyecto"].ToString(),
                dr["Modalidad"].ToString(),
                dr["Periodo"].ToString(),
                int.Parse(dr["Anio"].ToString()),
                dr["AsesorExt"].ToString(),
                dr["PuestoAsesor"].ToString(),
                dr["Responsable"].ToString(),
                dr["PuestoRespo"].ToString(),
                dr["IdEmpresa"].ToString(),
                dr["IdAlumno"].ToString()
            );
        }


        //TODO : Revisar si faltan campos en la base de datos
    }    
}
