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
    /// Objeto de acceso a datos de dictamen.
    /// </summary>
    /// <remarks>
    /// Permite acceder a los datos almacenados del dictamen.
    /// </remarks>
    class DictamenDAO
    {
        /// <summary>
        /// Busca y obtiene un dictamen que coincida con la id de
        /// la residencia ingresado como parámetro.
        /// </summary>
        /// <param name="idResidencia"></param>
        /// Id utilizado para identificar al dictamen.
        /// <returns>
        /// Retorna el dictamen si es encontrado, de otro modo retorna null.
        /// </returns>
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

        /// <summary>
        /// Busca y obtiene el dictamen asesor que coincida con la id 
        /// de la residencia ingresada como parámetro.
        /// </summary>
        /// <param name="idResidencia"></param>
        /// Id utilizado para identificar al dictamen.
        /// <returns>
        /// Retorna el dictamen asesor si es encontrado, de otro modo retorna null.
        /// </returns>
        public static DictamenPOJO ObtenerDictamenAsesor(int idResidencia)
        {
            try
            {
                Conexion con = new Conexion();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM dictamen WHERE IdResidencia = @P0 and tipo like 'LiberacionAsesor'");
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

        /// <summary>
        /// Busca y obtiene el dictamen que coincida con los 
        /// parámetros ingresados.
        /// </summary>
        /// <param name="idDocente"></param>
        /// Identificador del docente.
        /// /// <param name="idAlumno"></param>
        /// Identificador del alumno.
        /// /// <param name="tipo"></param>
        /// Tipo de dictamen a buscado.
        /// <returns>
        /// Retorna el dictamen especificado si es encontrado, de otro modo retorna 
        /// null.
        /// </returns>
        public static DictamenPOJO ObtenerDictamen(String idDocente, String idAlumno, String tipo)
        {
            try
            {
                var idResidencia = SolicitudDAO.ObtenerSolicitud(idAlumno).IdResidencia;

                Conexion con = new Conexion();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM dictamen WHERE IdDocente=@P0 AND " +
                    "IdResidencia=@P1 AND Tipo=@P2");
                cmd.Parameters.AddWithValue("@P0", idDocente);
                cmd.Parameters.AddWithValue("@P1", idResidencia);
                cmd.Parameters.AddWithValue("@P2", tipo);

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
        /// Busca y obtiene todos los dictamenes de revisores que coincidan 
        /// con la id de la residencia ingresada como parámetro.
        /// </summary>
        /// <param name="idResidencia"></param>
        /// Id utilizado para identificar al dictamen.
        /// <returns>
        /// Retorna los dictamenes de revisores si son encontrados, 
        /// de otro modo retorna null.
        /// </returns>
        public static List<DictamenPOJO> ObtenerDictamenesRevisores(int idResidencia)
        {
            try
            {
                var list = new List<DictamenPOJO>();

                Conexion con = new Conexion();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM dictamen WHERE IdResidencia = @P0 and tipo like 'LiberacionRevisor'");
                cmd.Parameters.AddWithValue("@P0", idResidencia);

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
        /// Busca y obtiene todos los dictamenes de liberación final almacenados
        /// en la base de datos.
        /// </summary>
        /// <returns>
        /// Retorna los dictamenes de liberación final obtenidos a través de la
        /// consulta.
        /// </returns>
        public static List<DictamenPOJO> ObtenerProyectosTerminados()
        {
            try
            {
                var list = new List<DictamenPOJO>();

                Conexion con = new Conexion();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM dictamen where tipo like 'LiberacionFinal'");

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
        /// Asigna la calificación emitida por el asesor.
        /// </summary>
        /// <param name="idResidencia"></param>
        /// Id utilizado para identificar al proyecto.
        /// /// <param name="calificacion"></param>
        /// Contiene la calificación a ingresar.
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

        /// <summary>
        /// Almacena un nuevo dictamen en la base de datos.
        /// </summary>
        /// <param name="dictamen"></param>
        /// Dictamen a ingresar en la base de datos.
        /// <returns>
        /// Retorna true si la inserción tuvo exito, de otro modo retorna
        /// false.
        /// </returns>
        public static bool InsertarDictamen(DictamenPOJO dictamen)
        {
            try
            {
                Conexion con = new Conexion();
                MySqlCommand cmd = new MySqlCommand("INSERT INTO dictamen VALUES(null,@P1,@P2,@P3,@P4,@P5,@P6,@P7);");
                
                cmd.Parameters.AddWithValue("@P1", dictamen.IdResidencia);
                cmd.Parameters.AddWithValue("@P2", dictamen.IdDocente);
                cmd.Parameters.AddWithValue("@P3", dictamen.Tipo);
                cmd.Parameters.AddWithValue("@P4", dictamen.Estatus);
                cmd.Parameters.AddWithValue("@P5", dictamen.Comentario);
                cmd.Parameters.AddWithValue("@P6", dictamen.Calificacion);
                cmd.Parameters.AddWithValue("@P7", dictamen.Fecha);

                con.ejecutarSentencia(cmd, true);
                return true;
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
        /// Obtiene los dictamenes de liberación asesor emitidos por el docente ingresado
        /// como parámetro.
        /// </summary>
        /// <param name="idDocente"></param>
        /// Identificador del docente usado para filtrar los dictamenes.
        /// <returns>
        /// Retorna los dictamenes de liberación asesor obtenidos a través de la
        /// consulta.
        /// </returns>
        public static List<DictamenPOJO> ObtenerLiberacionesAsesor(String idDocente)
        {
            try
            {
                var list = new List<DictamenPOJO>();

                Conexion con = new Conexion();
                MySqlCommand cmd = new MySqlCommand("SELECT d.* FROM alumno al JOIN roldocente rol " +
                    "ON al.Matricula = rol.idAlumno JOIN InfoResidencia i ON al.Matricula = i.idAlumno JOIN " +
                    "dictamen d ON i.ID = d.idResidencia WHERE rol.IdDocente = @P0 AND rol.Rol = 'Asesor' AND d.tipo = 'LiberacionAsesor' " +
                    "AND al.Matricula NOT IN(SELECT i.idAlumno FROM InfoResidencia i JOIN dictamen d ON "+
                    "i.ID = d.idResidencia  WHERE d.tipo = 'LiberacionFinal'); ");
                cmd.Parameters.AddWithValue("@P0", idDocente);

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
        /// Construye un dictamen con los datos ingresados como parámetro.
        /// </summary>
        /// <param name="dr"></param>
        /// Registro de datos pertenecientes al alumno.
        /// <returns>
        /// Retorna el dictamen creado.
        /// </returns>
        public static DictamenPOJO DataRowAObjeto(DataRow dr)
        {
            int calf = 0;
            int.TryParse(dr["Calificacion"].ToString(), out calf);
            return new DictamenPOJO(
                int.Parse(dr["ID"].ToString()),
                int.Parse(dr["IdResidencia"].ToString()),
                dr["IdDocente"].ToString(),
                dr["Tipo"].ToString(),
                dr["Estatus"].ToString(),
                dr["Comentario"].ToString(),
                calf,
                DateTime.Parse(dr["Fecha"].ToString()));
        }
    }
}