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
