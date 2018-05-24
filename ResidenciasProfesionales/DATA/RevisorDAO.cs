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
    /// Objeto de acceso a datos de revisor.
    /// </summary>
    /// <remarks>
    /// Permite acceder a los datos almacenados del revisor.
    /// </remarks>
    class RevisorDAO
    {
        /// <summary>
        /// Obtiene a todos los revisores almacenados en la base de datos así como 
        /// sus atributos.
        /// </summary>
        /// <returns>
        /// Retorna una lista con los revisores obtenidos a través de la consulta.
        /// </returns>
        public List<DocentePOJO> ObtenerTodos()
        {

            try
            {
                var list = new List<DocentePOJO>();

                Conexion con = new Conexion();
                MySqlCommand cmd = new MySqlCommand("select DISTINCT d.ID, d.Nombre, d.ApellidoP, d.ApellidoM, d.Correo, d.Telefono, d.Carrera, d.Usuario, d.Password, d.Estatus, (select count(rd2.IdDocente)as Revisor from roldocente rd2 join docente d2 on rd2.IdDocente = d2.ID where rd2.Rol = 'Revisor' and rd2.IdDocente =  rd.IdDocente) as CargaActual from roldocente rd join docente d on rd.IdDocente = d.ID where rd.Rol = 'Revisor';");

                DataTable dt = con.ejecutarConsulta(cmd);

                foreach (DataRow dr in dt.Rows)
                    list.Add(new DocentePOJO(dr["Id"].ToString(), dr["Nombre"].ToString(), dr["ApellidoP"].ToString(),
                    dr["ApellidoM"].ToString(), dr["Correo"].ToString(), dr["Telefono"].ToString(),
                    int.Parse(dr["Carrera"].ToString()), dr["Estatus"].ToString(), dr["CargaActual"].ToString()));

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
        
            public static int EliminarRevisor(String NoControl)
        {
            try
            {
                Conexion con = new Conexion();
                MySqlCommand cmd = new MySqlCommand("DELETE FROM rolDocente WHERE idAlumno = @P0 and Rol = 'Revisor';");
                cmd.Parameters.AddWithValue("@P0", NoControl);
                con.ejecutarSentencia(cmd, true);
                Conexion.conexion.Close();
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
        /// Asigna los revisores al alumno, los datos necesarios
        /// son ingresados como parámetro.
        /// </summary>
        /// <param name="NoControl"></param>
        /// Identificador del alumno al cual se le asignarán los
        /// revisores.
        /// <param name="claveDocente"></param>
        /// Identificador del docente que será uno de los revisores
        /// del alumno.
        /// <param name="claveDocente2"></param>
        /// Identificador del docente que será uno de los revisores
        /// del alumno.
        /// <returns>
        /// Retorna -1 si la sentencia no se ejecuto correctamente.
        /// </returns>
        public static int InsertarRevisor(String NoControl, String claveDocente, String claveDocente2)
        {
            try
            {
                Conexion con = new Conexion();
                MySqlCommand cmd = new MySqlCommand("INSERT INTO rolDocente VALUES(@P0,@P1,'Revisor'); SELECT last_insert_id();");
                cmd.Parameters.AddWithValue("@P0", NoControl);
                cmd.Parameters.AddWithValue("@P1", claveDocente);
                con.ejecutarSentencia(cmd, true);
                Conexion.conexion.Close();

                con = new Conexion();
                cmd = new MySqlCommand("INSERT INTO rolDocente VALUES(@P0,@P1,'Revisor'); SELECT last_insert_id();");
                cmd.Parameters.AddWithValue("@P0", NoControl);
                cmd.Parameters.AddWithValue("@P1", claveDocente2);

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

    }
}
