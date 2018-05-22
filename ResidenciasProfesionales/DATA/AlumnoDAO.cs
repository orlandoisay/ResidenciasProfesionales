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
    /// Objeto de acceso a datos de alumno.
    /// </summary>
    /// <remarks>
    /// Permite acceder a los datos almacenados del alumno.
    /// </remarks>
    public class AlumnoDAO
    {
        /// <summary>
        /// Obtiene a todos los alumnos almacenados en la base de datos así como 
        /// sus atributos.
        /// </summary>
        /// <returns>
        /// Retorna una lista con los alumnos obtenidos a través de la consulta.
        /// </returns>
        public static List<AlumnoPOJO> ObtenerTodos()
        {
            try
            {
                var list = new List<AlumnoPOJO>();

                Conexion con = new Conexion();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM alumno");

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
        /// Obtiene a todos los alumnos sin asesor
        /// </summary>
        /// <returns>
        /// Retorna una lista con los alumnos sin asesor obtenidos a través de la 
        /// consulta.
        /// </returns>
        public static List<AlumnoPOJO> ObtenerAlumnosSinAsesor()
        {
            try
            {
                var list = new List<AlumnoPOJO>();

                Conexion con = new Conexion();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM alumno WHERE Matricula NOT IN " +
                    "( SELECT IdAlumno FROM roldocente WHERE Rol = 'Asesor');");

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
        /// Obtiene a todos los alumnos sin asesor y con su solicitud de residencias
        /// aprobada.
        /// </summary>
        /// <returns>
        /// Retorna una lista con los alumnos sin asesor y con solicitud aprobada 
        /// obtenidos a través de la consulta.
        /// </returns>
        public static List<AlumnoPOJO> ObtenerAlumnosSinAsesorSolicitudAprobada()
        {
            try
            {
                var list = new List<AlumnoPOJO>();

                Conexion con = new Conexion();
                MySqlCommand cmd = new MySqlCommand("SELECT DISTINCT al.* FROM alumno al JOIN solicitud sol ON al.matricula = sol.idAlumno " +
                "WHERE Matricula NOT IN(SELECT IdAlumno FROM roldocente WHERE Rol = 'Asesor') AND sol.Estatus = 'Aceptado'; ");

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
        /// Obtiene a todos los alumnos con documentación y/o calificación 
        /// pendiente.
        /// </summary>
        /// <param name="idDocente"></param>
        /// Clave del docente utilizado para filtrar a los alumnos.
        /// <returns>
        /// Retorna una lista con los alumnos con documentación y/o calificación 
        /// pendiente obtenidos a través de la consulta.
        /// </returns>
        public static List<AlumnoPOJO> ObtenerAlumnosConAsesorSinLiberarlo(String idDocente)
        {
            try
            {
                var list = new List<AlumnoPOJO>();

                Conexion con = new Conexion();
                MySqlCommand cmd = new MySqlCommand("SELECT al.* FROM alumno al JOIN roldocente rol WHERE "+
                    "al.Matricula = rol.idAlumno AND rol.Rol = 'Asesor' AND rol.IdDocente = @P0 AND al.Matricula "+
                    "NOT IN(SELECT i.idAlumno FROM InfoResidencia i JOIN dictamen d ON i.ID = d.idResidencia "+
                    "WHERE d.tipo = 'LiberacionAsesor');");
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
        /// Obtiene a todos los alumnos con asesor asignado y sin terminar el 
        /// proceso de residencias profesionales.
        /// </summary>
        /// <returns>
        /// Retorna una lista con asesor asignado y sin terminar el proceso de 
        /// residencias profesionales obtenidos a través de la consulta.
        /// </returns>
        public static List<AlumnoPOJO> ObtenerAlumnosConAsesorSinLiberarResidencias()
        {
            try
            {
                var list = new List<AlumnoPOJO>();

                Conexion con = new Conexion();
                MySqlCommand cmd = new MySqlCommand("SELECT al.* FROM alumno al JOIN roldocente rol WHERE "+
                    "al.Matricula = rol.idAlumno AND rol.Rol = 'Asesor' AND al.Matricula NOT IN"+
                    "(SELECT i.idAlumno FROM InfoResidencia i JOIN dictamen d ON i.ID = d.idResidencia WHERE "+
                    "d.tipo = 'LiberacionFinal');");

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
        /// Obtiene a todos los alumnos con asesor asignado
        /// </summary>
        /// <returns>
        /// Retorna una lista con los alumnos con asesor obtenidos 
        /// a través de la consulta.
        /// </returns>
        public static List<AlumnoPOJO> ObtenerAlumnosConAsesor()
        {
            try
            {
                var list = new List<AlumnoPOJO>();

                Conexion con = new Conexion();
                MySqlCommand cmd = new MySqlCommand("SELECT al.* FROM alumno al JOIN roldocente rol " +
                    "WHERE al.Matricula = rol.idAlumno AND rol.Rol = 'Asesor';");

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
        /// Obtiene a todos los asesorados del docente ingresado como parámetro.
        /// </summary>
        /// <param name="idDocente"></param>
        /// Clave del docente utilizado para filtrar a los alumnos.
        /// <returns>
        /// Retorna una lista con los alumnos asesorados del docente ingresado como 
        /// parámetro obtenidos a través de la consulta.
        /// </returns>
        public static List<AlumnoPOJO> ObtenerAlumnosPorDocente(String idDocente)
        {
            try
            {
                var list = new List<AlumnoPOJO>();

                Conexion con = new Conexion();
                MySqlCommand cmd = new MySqlCommand("SELECT* FROM alumno A JOIN roldocente R ON A.Matricula=R.IdAlumno WHERE IdDocente=@P0");
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
        /// Busca y obtiene al alumno que coincida con la matricula ingresada
        /// como parámetro.
        /// </summary>
        /// <param name="matricula"></param>
        /// Matricula utilizada para identificar al alumno.
        /// <returns>
        /// Retorna al alumno si es encontrado, de otro modo retorna null.
        /// </returns>
        public static AlumnoPOJO ObtenerAlumno(string matricula)
        {
            try
            {
                Conexion con = new Conexion();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM alumno WHERE Matricula LIKE @P0");
                cmd.Parameters.AddWithValue("@P0", matricula);

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
        /// Obtiene a los alumnos cuya calificación ya ha sido asignada.
        /// </summary>
        /// <param name="idDocente"></param>
        /// Clave del docente utilizado para filtrar a los alumnos.
        /// <returns>
        /// Retorna una lista con los alumnos cuya calificación ya ha sido asignada 
        /// obtenidos a través de la consulta.
        /// </returns>
        public static List<AlumnoPOJO> ObtenerAlumnosConLiberacionAsesor(String idDocente)
        {
            try
            {
                var list = new List<AlumnoPOJO>();

                Conexion con = new Conexion();
                MySqlCommand cmd = new MySqlCommand("SELECT al.* FROM alumno al JOIN roldocente rol ON "+
                    "al.Matricula = rol.idAlumno JOIN InfoResidencia i ON al.Matricula = i.idAlumno JOIN "+
                    "dictamen d ON i.ID = d.idResidencia WHERE rol.IdDocente = @P0 AND " +
                    "d.tipo = 'LiberacionAsesor' AND al.Matricula NOT IN(SELECT i.idAlumno FROM "+
                    "InfoResidencia i JOIN dictamen d ON i.ID = d.idResidencia  WHERE d.tipo = 'LiberacionFinal');");
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
        /// Remplaza al alumno ubicado en la base de datos por el
        /// alumno ingresado como parametro.
        /// </summary>
        /// <param name="alumno"></param>
        /// Contiene los datos del alumno que remplazará al alumno almacenado.
        public static void Actualizar(AlumnoPOJO alumno)
        {
            try
            {
                Conexion con = new Conexion();
                MySqlCommand cmd = new MySqlCommand("UPDATE alumno SET Password=@P1, Nombre=@P2, ApellidoP=@P3, " +
                    "ApellidoM=@P4, Correo=@P5, Telefono=@P6, Carrera=@P7, Semestre=@P8, TipoSS=@P9, NumeroSS=@P10, " +
                    "Estatus=@P11, Domicilio=@P12, Ciudad=@P13 WHERE Matricula=@P0");
                cmd.Parameters.AddWithValue("@P0", alumno.Matricula);
                cmd.Parameters.AddWithValue("@P1", alumno.Password);
                cmd.Parameters.AddWithValue("@P2", alumno.Nombre);
                cmd.Parameters.AddWithValue("@P3", alumno.ApellidoP);
                cmd.Parameters.AddWithValue("@P4", alumno.ApellidoM);
                cmd.Parameters.AddWithValue("@P5", alumno.Correo);
                cmd.Parameters.AddWithValue("@P6", alumno.Telefono);
                cmd.Parameters.AddWithValue("@P7", alumno.Carrera);
                cmd.Parameters.AddWithValue("@P8", alumno.Semestre);
                cmd.Parameters.AddWithValue("@P9", alumno.TipoSS);
                cmd.Parameters.AddWithValue("@P10", alumno.NumeroSS);
                cmd.Parameters.AddWithValue("@P11", alumno.Estatus);
                cmd.Parameters.AddWithValue("@P12", alumno.Domicilio);
                cmd.Parameters.AddWithValue("@P13", alumno.Ciudad);

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
        /// Construye un alumno con los datos ingresados como parámetro.
        /// </summary>
        /// <param name="dr"></param>
        /// Registro de datos pertenecientes al alumno.
        /// <returns>
        /// Retorna el alumno creado.
        /// </returns>
        public static AlumnoPOJO DataRowAObjeto(DataRow dr)
        {
            return new AlumnoPOJO(
                dr["Matricula"].ToString(),
                dr["Password"].ToString(),
                dr["Nombre"].ToString(),
                dr["ApellidoP"].ToString(),
                dr["ApellidoM"].ToString(),
                dr["Correo"].ToString(),
                dr["Telefono"].ToString(),
                int.Parse(dr["Carrera"].ToString()),
                int.Parse(dr["Semestre"].ToString()),
                dr["TipoSS"].ToString(),
                dr["NumeroSS"].ToString(),
                dr["Estatus"].ToString(),
                dr["Domicilio"].ToString(),
                dr["Ciudad"].ToString()
            );

        }
    }
}
