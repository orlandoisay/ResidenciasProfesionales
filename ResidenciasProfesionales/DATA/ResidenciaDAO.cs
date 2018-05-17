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

        public static List<ResidenciaPOJO> ObtenerResidencias()
        {
            try
            {
                var list = new List<ResidenciaPOJO>();

                Conexion con = new Conexion();
                MySqlCommand cmd = new MySqlCommand("select * from inforesidencia;");

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

        public static List<ResidenciaPOJO> ObtenerResidenciaLiberacion()
        {
            try
            {
                var list = new List<ResidenciaPOJO>();

                Conexion con = new Conexion();
                MySqlCommand cmd = new MySqlCommand("select * from inforesidencia r where r.ID not in (select distinct d.IdResidencia from dictamen d where d.Tipo like 'LiberacionFinal') and (select count(*) from dictamen d where r.ID = d.IdResidencia and d.Tipo in ('LiberacionAsesor','LiberacionRevisor') and d.Estatus like 'Aceptado') > 2;");

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

        public static ResidenciaPOJO ObtenerResidenciaXMatricula(String idAlumno)
        {
            try
            {
                Conexion con = new Conexion();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM infoResidencia WHERE idAlumno = @P0;");
                cmd.Parameters.AddWithValue("@P0", idAlumno);

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

        public static int InsertarResidencia(ResidenciaPOJO residencia)
        {
            try
            {
                Conexion con = new Conexion();
                MySqlCommand cmd = new MySqlCommand("INSERT INTO inforesidencia VALUES(null,@P1,@P2,@P3,@P4,@P5,@P6,@P7,@P8,@P9,@P10); SELECT last_insert_id();");
                
                cmd.Parameters.AddWithValue("@P1", residencia.NombreProyec);
                cmd.Parameters.AddWithValue("@P2", residencia.Modalidad);
                cmd.Parameters.AddWithValue("@P3", residencia.Periodo);
                cmd.Parameters.AddWithValue("@P4", residencia.Anio);
                cmd.Parameters.AddWithValue("@P5", residencia.AsesorExt);
                cmd.Parameters.AddWithValue("@P6", residencia.PuestoAsesor);
                cmd.Parameters.AddWithValue("@P7", residencia.Responsable);
                cmd.Parameters.AddWithValue("@P8", residencia.PuestoResp);
                cmd.Parameters.AddWithValue("@P9", residencia.IdEmpresa);
                cmd.Parameters.AddWithValue("@P10", residencia.IdAlumno);

                return con.ejecutarSentencia(cmd, true);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return -1;
            }
            finally
            {
                if (Conexion.conexion != null)
                    Conexion.conexion.Close();
            }
        }
        public static bool ActualizarResidencia(ResidenciaPOJO residencia)
        {
            try
            {
                Conexion con = new Conexion();
                MySqlCommand cmd = new MySqlCommand("UPDATE inforesidencia SET NombreProyecto=@P1, Modalidad=@P2, " +
                    "Periodo=@P3, Anio=@P4, AsesorExt=@P5, PuestoAsesor=@P6, Responsable=@P7, PuestoRespo=@P8, " +
                    "IdEmpresa=@P9, IdAlumno=@P10 WHERE ID=@P0");
                cmd.Parameters.AddWithValue("@P0", residencia.ID);
                cmd.Parameters.AddWithValue("@P1", residencia.NombreProyec);
                cmd.Parameters.AddWithValue("@P2", residencia.Modalidad);
                cmd.Parameters.AddWithValue("@P3", residencia.Periodo);
                cmd.Parameters.AddWithValue("@P4", residencia.Anio);
                cmd.Parameters.AddWithValue("@P5", residencia.AsesorExt);
                cmd.Parameters.AddWithValue("@P6", residencia.PuestoAsesor);
                cmd.Parameters.AddWithValue("@P7", residencia.Responsable);
                cmd.Parameters.AddWithValue("@P8", residencia.PuestoResp);
                cmd.Parameters.AddWithValue("@P9", residencia.IdEmpresa);
                cmd.Parameters.AddWithValue("@P10", residencia.IdAlumno);

                con.ejecutarSentencia(cmd, false);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
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
    }    
}
