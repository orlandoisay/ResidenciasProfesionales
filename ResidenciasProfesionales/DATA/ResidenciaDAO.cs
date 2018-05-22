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
    /// <summary>
    /// Objeto de acceso a datos de residencia.
    /// </summary>
    /// <remarks>
    /// Permite acceder a los datos almacenados de la residencia.
    /// </remarks>
    public class ResidenciaDAO
    {
        /// <summary>
        /// Obtiene todas las residencias almacenadas en la base de datos así como 
        /// sus atributos.
        /// </summary>
        /// <returns>
        /// Retorna una lista con las residencias obtenidos a través de la consulta.
        /// </returns>
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

        /// <summary>
        /// Obtiene todas las residencias en proceso que hayan aprobado la liberación
        /// asesor y la liberación revisor.
        /// </summary>
        /// <returns>
        /// Retorna una lista con las residencias obtenidos a través de la consulta.
        /// </returns>
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

        /// <summary>
        /// Busca y obtiene la residencia que coincida con el id ingresado
        /// como parámetro.
        /// </summary>
        /// <param name="id"></param>
        /// Identificador utilizado para identificar a la residencia.
        /// <returns>
        /// Retorna a la residencia si es encontrada, de otro modo retorna null.
        /// </returns>
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

        /// <summary>
        /// Busca y obtiene la residencia perteneciente al alumno
        /// ingresado como parámetro.
        /// </summary>
        /// <param name="idAlumno"></param>
        /// Identificador del alumno utilizado para identificar a 
        /// la residencia que le pertenece.
        /// <returns>
        /// Retorna a la residencia si es encontrada, de otro modo retorna null.
        /// </returns>
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

        /// <summary>
        /// Inserta una nueva residencia en la base de datos.
        /// </summary>
        /// <param name="residencia"></param>
        /// Contiene los datos que constituyen a una residencia.
        /// <returns>
        /// Retorna -1 si la sentencia no se ejecuto correctamente.
        /// </returns>
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

        /// <summary>
        /// Remplaza a la residencia ubicada en la base de datos por la
        /// residencia ingresada como parametro.
        /// </summary>
        /// <param name="residencia"></param>
        /// Contiene los datos de la residencia que remplazará a la 
        /// residencia almacenada.
        /// <returns>
        /// Retorna true si la sentencia se ejecuto correctamente,
        /// de otro modo retorna false.
        /// </returns>
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

        /// <summary>
        /// Construye una residencia con los datos ingresados como 
        /// parámetro.
        /// </summary>
        /// <param name="dr"></param>
        /// Registro de datos pertenecientes a la residencia.
        /// <returns>
        /// Retorna la residencia creada.
        /// </returns>
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
