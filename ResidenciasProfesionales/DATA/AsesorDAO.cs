using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ResidenciasProfesionales.MODEL;
using MySql.Data.MySqlClient;
using System.Data;

namespace ResidenciasProfesionales.DATA
{
    class AsesorDAO
    {

        public Asesor ObtenerAsesor(string iD)
        {
            try
            {
                Conexion con = new Conexion();
                MySqlCommand cmd = new MySqlCommand("select * from docente where ID = @P0;");
                cmd.Parameters.AddWithValue("@P0", iD);

                DataTable dt = con.ejecutarConsulta(cmd);
                if (dt.Rows.Count != 1)
                    return null;
                DataRow dr = dt.Rows[0];

                return new Asesor(dr["Id"].ToString(), dr["Nombre"].ToString(), dr["ApellidoP"].ToString(),
                    dr["ApellidoM"].ToString(), dr["Correo"].ToString(), dr["Telefono"].ToString(),
                    dr["Carrera"].ToString(), dr["Estatus"].ToString());
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

    }
}
