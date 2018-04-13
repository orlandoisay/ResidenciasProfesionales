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
    public class AlumnoDAO
    {
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
        public static void Actualizar(AlumnoPOJO alumno)
        {
            try
            {
                Conexion con = new Conexion();
                MySqlCommand cmd = new MySqlCommand("UPDATE alumno SET Password=@P0, Nombre=@P1, ApellidoP=@P2, " +
                    "ApellidoM=@P3, Correo=@P4, Telefono=@P5, Carrera=@P6, Semestre=@P7, Estatus=@P8");

                cmd.Parameters.AddWithValue("@P0", alumno.Password);
                cmd.Parameters.AddWithValue("@P1", alumno.Nombre);
                cmd.Parameters.AddWithValue("@P2", alumno.ApellidoP);
                cmd.Parameters.AddWithValue("@P3", alumno.ApellidoM);
                cmd.Parameters.AddWithValue("@P4", alumno.Correo);
                cmd.Parameters.AddWithValue("@P5", alumno.Telefono);
                cmd.Parameters.AddWithValue("@P6", alumno.Carrera);
                cmd.Parameters.AddWithValue("@P7", alumno.Semestre);
                cmd.Parameters.AddWithValue("@P8", alumno.Estatus);

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
                dr["Estatus"].ToString()
            );
        }
    }
}
