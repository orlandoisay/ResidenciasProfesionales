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
    /// <summary>
    /// Objeto de acceso a datos de docente.
    /// </summary>
    /// <remarks>
    /// Permite acceder a los datos almacenados del docente.
    /// </remarks>
    public class DocenteDAO
    {
        /// <summary>
        /// Obtiene a todos los docentes almacenados en la base de datos así como 
        /// sus atributos.
        /// </summary>
        /// <returns>
        /// Retorna una lista con los docentes obtenidos a través de la consulta.
        /// </returns>
        public static List<DocentePOJO> ObtenerTodos()
        {
            try
            {
                var list = new List<DocentePOJO>();

                Conexion con = new Conexion();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM docente");

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
        /// Busca y obtiene a todos los docentes capaces de actuar como
        /// asesor.
        /// </summary>
        /// <returns>
        /// Una lista de asesores disponibles.
        /// </returns>
        public static List<DocentePOJO> ObtenerTodosLosDisponibles()
        {
            try
            {
                var list = new List<DocentePOJO>();

                Conexion con = new Conexion();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM docente WHERE ID NOT IN (SELECT idDocente FROM roldocente WHERE Rol = 'Coordinador' OR Rol = 'Academia' OR Rol = 'Administrador');");

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
        /// Busca y obtiene al docente usando su identificador.
        /// </summary>
        /// <param name="ID"></param>
        /// Identificador del docente.
        /// <returns>
        /// Retorna al docente que coincide con el identificador ingresado.
        /// </returns>
        public static DocentePOJO ObtenerDocente(String ID)
        {
            try
            {
                Conexion con = new Conexion();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM docente WHERE ID LIKE @P0");
                cmd.Parameters.AddWithValue("@P0", ID);

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
        /// Busca y obtiene al asesor del alumno ingresado como parámetro.
        /// </summary>
        /// <param name="IdAlumno"></param>
        /// Identificador del alumno, utilizado para buscar a su asesor.
        /// <returns>
        /// Retorna al docente que asesora al alumno ingresado como parametro.
        /// </returns>
        public static DocentePOJO ObtenerDocenteXMatricula(String IdAlumno)
        {
            try
            {
                Conexion con = new Conexion();
                MySqlCommand cmd = new MySqlCommand("SELECT doc.* FROM docente doc JOIN roldocente rol ON doc.ID = rol.IdDocente WHERE rol.IdAlumno = @P0 AND Rol = 'Asesor';");
                cmd.Parameters.AddWithValue("@P0", IdAlumno);

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
        /// Busca y obtiene los datos del asesor usando el usuario
        /// del mismo.
        /// </summary>
        /// <param name="usuario"></param>
        /// Nombre de usuario, usado para ingresar a través del login.
        /// <returns>
        /// Retorna al docente que coincide con el nombre de usuario.
        /// </returns>
        public static DocentePOJO ObtenerDocenteXUsuario(String usuario)
        {
            try
            {
                Conexion con = new Conexion();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM docente WHERE Usuario = @P0;");
                cmd.Parameters.AddWithValue("@P0", usuario);

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
        /// Asigna un asesor a un alumno, ambos ingresados como 
        /// parámetros.
        /// </summary>
        /// <param name="idAlumno"></param>
        /// Alumno a quien se le asignará el asesor.
        /// <param name="idDocente"></param>
        /// Asesor que le será asignado al alumno.
        /// <returns>
        /// Retorna -1 si la sentencia no fue ejecutada correctamente.
        /// </returns>
        public static int AsignarAsesorado(String idAlumno, String idDocente)
        {
            try
            {
                Conexion con = new Conexion();
                MySqlCommand cmd = new MySqlCommand("INSERT INTO rolDocente VALUES(@P0, @P1, 'Asesor');");

                cmd.Parameters.AddWithValue("@P0", idAlumno);
                cmd.Parameters.AddWithValue("@P1", idDocente);

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
        /// Busca los alumnos a cargo del docente ingresado como parámetro.
        /// </summary>
        /// <param name="idDocente"></param>
        /// Identificador del docente utilizado como filtro.
        /// <returns>
        /// Retorna el número de alumnos que tienen asignado como asesor
        /// al docente ingresado como parámetro
        /// </returns>
        public static int ObtenerCantidadAsesorados(String idDocente)
        {
            try
            {
                Conexion con = new Conexion();
                MySqlCommand cmd = new MySqlCommand("SELECT COUNT(*) as numero FROM roldocente WHERE idDocente = @P0 AND rol = 'Asesor';");
                cmd.Parameters.AddWithValue("@P0", idDocente);

                DataTable dt = con.ejecutarConsulta(cmd);
                if (dt.Rows.Count != 1)
                    return 0;
                return int.Parse(dt.Rows[0]["numero"].ToString());
            }
            catch (Exception ex)
            {
                return 0;
            }
            finally
            {
                if (Conexion.conexion != null)
                    Conexion.conexion.Close();
            }
        }

        /// <summary>
        /// Permite cambiarle el asesor al alumno ingresado como parámetro.
        /// </summary>
        /// <param name="idDocenteNuevo"></param>
        /// Identificador del docente que remplazara al anterior.
        /// <param name="idAlumno"></param>
        /// Identificador del alumno.
        /// <param name="idDocenteNuevo"></param>
        /// Identificador del docente que será remplazado.
        /// <returns>
        /// Retorna una lista de 3 docentes: asesor, revisor 1 y revisor 2
        /// respectivamente. Dichos docentes deben estar enlazados al alumno
        /// previamante.
        /// </returns>
        public static void CambiarAsesor(String idDocenteNuevo, String idAlumno, String idDocenteAnterior)
        {
            try
            {
                Conexion con = new Conexion();
                MySqlCommand cmd = new MySqlCommand("UPDATE roldocente SET IdDocente = @P0 WHERE " +
                    "IdAlumno = @P1 AND IdDocente = @P2 AND Rol = 'Asesor';");
                cmd.Parameters.AddWithValue("@P0", idDocenteNuevo);
                cmd.Parameters.AddWithValue("@P1", idAlumno);
                cmd.Parameters.AddWithValue("@P2", idDocenteAnterior);

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
        /// Busca y obtiene a los responsables de evaluar al alumno ingresado
        /// como parámetro.
        /// </summary>
        /// <param name="idAlumno"></param>
        /// Identificador del alumno.
        /// <returns>
        /// Retorna una lista de 3 docentes: asesor, revisor 1 y revisor 2
        /// respectivamente. Dichos docentes deben estar enlazados al alumno
        /// previamante.
        /// </returns>
        public static List<DocentePOJO> ObtenerResponsablesDeAlumno(String idAlumno)
        {
            try
            {
                var list = new List<DocentePOJO>();

                Conexion con = new Conexion();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM roldocente R JOIN docente D ON R.IdDocente=D.ID WHERE IdAlumno=@P0 ORDER BY Rol, IdDocente");
                cmd.Parameters.AddWithValue("@P0", idAlumno);

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
        /// Construye un docente con los datos ingresados como parámetro.
        /// </summary>
        /// <param name="dr"></param>
        /// Registro de datos pertenecientes al docente.
        /// <returns>
        /// Retorna el docente creado.
        /// </returns>
        public static DocentePOJO DataRowAObjeto(DataRow dr)
        {

            return new DocentePOJO(
                dr["ID"].ToString(),
                dr["Nombre"].ToString(),
                dr["ApellidoP"].ToString(),
                dr["ApellidoM"].ToString(),
                dr["Correo"].ToString(),
                dr["Telefono"].ToString(),
                int.Parse(dr["Carrera"].ToString()),
                dr["Usuario"].ToString(),
                dr["Password"].ToString(),
                dr["Estatus"].ToString()
            );

        }
    }
}
