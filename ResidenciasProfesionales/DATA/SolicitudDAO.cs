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
    /// Objeto de acceso a datos de solicitud.
    /// </summary>
    /// <remarks>
    /// Permite acceder a los datos almacenados de la 
    /// solicitud.
    /// </remarks>
    public class SolicitudDAO
    {
        /// <summary>
        /// Obtiene todas las solicitudes almacenadas en la base de datos 
        /// así como sus atributos.
        /// </summary>
        /// <returns>
        /// Retorna una lista con las solicitudes obtenidos a través de la 
        /// consulta.
        /// </returns>
        public List<SolicitudPOJO> ObtenerTodos()
        {
            try
            {
                var list = new List<SolicitudPOJO>();

                Conexion con = new Conexion();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM solicitud");

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
        /// Busca y obtiene la solicitud que coincida con el id ingresado
        /// como parámetro.
        /// </summary>
        /// <param name="id"></param>
        /// Identificador utilizado para ubicar la solicitud.
        /// <returns>
        /// Retorna la solicitud si es encontrada, de otro modo retorna null.
        /// </returns>
        public static SolicitudPOJO ObtenerSolicitud(int id)
        {
            try
            {
                Conexion con = new Conexion();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM solicitud WHERE id = @P0");
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
        /// Busca y obtiene la solicitud que coincida con la matricula
        /// del alumno ingresado como parámetro.
        /// </summary>
        /// <param name="idAlumno"></param>
        /// Matricula utilizada para ubicar la solicitud.
        /// <returns>
        /// Retorna la solicitud si es encontrada, de otro modo retorna null.
        /// </returns>
        public static SolicitudPOJO ObtenerSolicitud(string idAlumno)
        {
            try
            {
                Conexion con = new Conexion();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM solicitud WHERE idAlumno = @P0");
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
        /// Obtiene todas las solicitudes almacenados en la base de datos 
        /// que se encuentren pendientes.
        /// </summary>
        /// <returns>
        /// Retorna una lista con las solicitudes obtenidas a través de la 
        /// consulta.
        /// </returns>
        public static List<SolicitudPOJO> ObtenerSolicitudesPendientes()
        {
            try
            {
                var list = new List<SolicitudPOJO>();

                Conexion con = new Conexion();
                MySqlCommand cmd = new MySqlCommand("SELECT* FROM solicitud WHERE estatus like 'Pendiente'");

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
        /// Inserta una nueva solicitud en la base de datos.
        /// </summary>
        /// <param name="solicitud"></param>
        /// Contiene los datos que constituyen una solicitud.
        /// <returns>
        /// Retorna -1 si la sentencia no se ejecuto correctamente.
        /// </returns>
        public static int InsertarSolicitud(SolicitudPOJO solicitud)
        {
            try
            {
                Conexion con = new Conexion();
                MySqlCommand cmd = new MySqlCommand("INSERT INTO solicitud VALUES(null,@P1,@P2,@P3); SELECT last_insert_id();");
                cmd.Parameters.AddWithValue("@P1", solicitud.IdAlumno);
                cmd.Parameters.AddWithValue("@P2", solicitud.IdResidencia);
                cmd.Parameters.AddWithValue("@P3", solicitud.Estatus);

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

        /// <summary>
        /// Remplaza a la solicitud ubicada en la base de datos por la
        /// solicitud ingresada como parametro.
        /// </summary>
        /// <param name="solicitud"></param>
        /// Contiene los datos de la solicitud que remplazará a la 
        /// solicitud almacenada.
        /// <returns>
        /// Retorna true si la sentencia se ejecuto correctamente,
        /// de otro modo retorna false.
        /// </returns>
        public static void Actualizar(SolicitudPOJO solicitud)
        {
            try
            {
                Conexion con = new Conexion();
                MySqlCommand cmd = new MySqlCommand("UPDATE solicitud SET idAlumno=@P1, idResidencia=@P2, Estatus='Aceptado' " +
                    "WHERE id=@P0");
                cmd.Parameters.AddWithValue("@P0", solicitud.ID);
                cmd.Parameters.AddWithValue("@P1", solicitud.IdAlumno);
                cmd.Parameters.AddWithValue("@P2", solicitud.IdResidencia);

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

        /// <summary>
        /// Construye una solicitud con los datos ingresados como parámetro.
        /// </summary>
        /// <param name="dr"></param>
        /// Registro de datos pertenecientes a la solicitud.
        /// <returns>
        /// Retorna la solicitud creada.
        /// </returns>
        public static SolicitudPOJO DataRowAObjeto(DataRow dr)
        {
            return new SolicitudPOJO(
                int.Parse(dr["id"].ToString()),
                dr["idAlumno"].ToString(),
                int.Parse(dr["idResidencia"].ToString()),
                dr["Estatus"].ToString()
            );
        }
    }
}
