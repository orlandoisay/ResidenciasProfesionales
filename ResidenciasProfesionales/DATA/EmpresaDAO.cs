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
    public class EmpresaDAO
    {
        public static EmpresaPOJO ObtenerEmpresa(string rfc)
        {
            try
            {
                Conexion con = new Conexion();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM empresa WHERE rfc = @P0");
                cmd.Parameters.AddWithValue("@P0", rfc);

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
        public static int InsertarEmpresa(EmpresaPOJO empresa)
        {
            try
            {
                Conexion con = new Conexion();
                MySqlCommand cmd = new MySqlCommand("INSERT INTO empresa VALUES(@P0,@P1,@P2,@P3,@P4,@P5,@P6,@P7,@P8,@P9,@P10,@P11); SELECT last_insert_id();");
                cmd.Parameters.AddWithValue("@P0", empresa.RFC);
                cmd.Parameters.AddWithValue("@P1", empresa.Nombre);
                cmd.Parameters.AddWithValue("@P2", empresa.Sector);
                cmd.Parameters.AddWithValue("@P3", empresa.Domicilio);
                cmd.Parameters.AddWithValue("@P4", empresa.Colonia);
                cmd.Parameters.AddWithValue("@P5", empresa.Ciudad);
                cmd.Parameters.AddWithValue("@P6", empresa.CP);
                cmd.Parameters.AddWithValue("@P7", empresa.Telefono);
                cmd.Parameters.AddWithValue("@P8", empresa.Fax);
                cmd.Parameters.AddWithValue("@P9", empresa.Mision);
                cmd.Parameters.AddWithValue("@P10", empresa.Titular);
                cmd.Parameters.AddWithValue("@P11", empresa.PuestoTit);

                return con.ejecutarSentencia(cmd, true);
            }
            catch (Exception ex)
            {
                return -1;
            }
            finally
            {
                if (Conexion.conexion != null)
                    Conexion.conexion.Close();
            }
        }

        public static EmpresaPOJO DataRowAObjeto(DataRow dr)
        {
            return new EmpresaPOJO(
                dr["RFC"].ToString(),
                dr["Nombre"].ToString(),
                dr["Giro"].ToString(),
                dr["Sector"].ToString(),
                dr["Domicilio"].ToString(),
                dr["Colonia"].ToString(),
                dr["Ciudad"].ToString(),
                dr["CP"].ToString(),
                dr["Telefono"].ToString(),
                dr["Fax"].ToString(),
                dr["Mision"].ToString(),
                dr["Titular"].ToString(),
                dr["PuestoTitu"].ToString()
            );
        }

    }
}
