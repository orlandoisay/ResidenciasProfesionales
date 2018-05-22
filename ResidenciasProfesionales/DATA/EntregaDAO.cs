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
    /// Objeto de acceso a datos de entrega.
    /// </summary>
    /// <remarks>
    /// Permite acceder a los datos almacenados de las entregas.
    /// </remarks>
    public class EntregaDAO
    {
        /// <summary>
        /// Obtiene todas las entregas almacenados en la base de datos así como 
        /// sus atributos.
        /// </summary>
        /// <returns>
        /// Retorna una lista con las entregas obtenidos a través de la consulta.
        /// </returns>
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

        /// <summary>
        /// Busca y obtiene una entrega usando los parámetros para ubicarla.
        /// </summary>
        /// <param name="idAlumno"></param>
        /// Identificador del alumno.
        /// <param name="idDocumento"></param>
        /// Identificador del documento.
        /// <returns>
        /// Retorna el documento buscado si es encontrado, si no es así
        /// retorna null.
        /// </returns>
        public static EntregaPOJO ObtenerEntrega(String idAlumno, int idDocumento)
        {
            try
            {
                Conexion con = new Conexion();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM entregaDocumento WHERE idAlumno like @P0 and idDocumento = @P1;");
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

        /// <summary>
        /// Obtiene todos los documentos almacenados en la base de datos 
        /// que se encuentren pendientes.
        /// </summary>
        /// <returns>
        /// Retorna una lista con todos los documentos pendientes.
        /// </returns>
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

        /// <summary>
        /// Inserta los documentos necesarios para el proceso de
        /// liberación asesor, con objetivo de manipular su estado
        /// de pendiente a entregado o viceversa, según corresponda.
        /// </summary>
        /// <returns>
        /// Retorna -1 si la sentencia no se ejecuto correctamente.
        /// </returns>
        public static int InsertarDocumentosPendientes(String idAlumno)
        {
            try
            {
                Conexion con = new Conexion();
                MySqlCommand cmd = new MySqlCommand("INSERT INTO entregaDocumento VALUES(@P0, 3, 'Pendiente'),(@P0, 4, 'Pendiente'),"
                + "(@P0, 5, 'Pendiente'), (@P0, 6, 'Pendiente'), (@P0, 7, 'Pendiente'),"
                + "(@P0, 8, 'Pendiente'); ");

                cmd.Parameters.AddWithValue("@P0", idAlumno);

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
        /// Usa los parámetros ingresados para ubicar un documento y
        /// cambiar su estado.
        /// </summary>
        /// <param name="estado"></param>
        /// Contiene el estado por el cual se cambiará.
        /// <param name="idAlumno"></param>
        /// Identificador del alumno.
        /// <param name="idDocumento"></param>
        /// Identificador del documento.
        /// <returns>
        public static void CambiarEstadoDocumento(String estado, String idAlumno, int idDocumento)
        {
            try
            {
                Conexion con = new Conexion();
                MySqlCommand cmd = new MySqlCommand("UPDATE entregaDocumento SET estado = @P0 " +
                    "WHERE idAlumno = @P1 AND idDocumento = @P2;");
                cmd.Parameters.AddWithValue("@P0", estado);
                cmd.Parameters.AddWithValue("@P1", idAlumno);
                cmd.Parameters.AddWithValue("@P2", idDocumento);

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
        /// Construye una entrega con los datos ingresados como parámetro.
        /// </summary>
        /// <param name="dr"></param>
        /// Registro de datos pertenecientes a la entrega.
        /// <returns>
        /// Retorna la entrega creada.
        /// </returns>
        public static EntregaPOJO DataRowAObjeto(DataRow dr)
        {
            return new EntregaPOJO(
                dr["idAlumno"].ToString(),
                int.Parse(dr["idDocumento"].ToString()),
                dr["Estado"].ToString()
            );
        }
    }
}
