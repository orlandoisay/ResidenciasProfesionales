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
    /// Objeto de acceso a datos de carrera.
    /// </summary>
    /// <remarks>
    /// Permite acceder a los datos almacenados de la carrera.
    /// </remarks>
    public class CarreraDAO
    {
        /// <summary>
        /// Obtiene todas las carreras almacenados en la base de datos así como 
        /// sus atributos.
        /// </summary>
        /// <returns>
        /// Retorna una lista con las carreras obtenidos a través de la consulta.
        /// </returns>
        public static List<CarreraPOJO> ObtenerTodas()
        {
            try
            {
                var list = new List<CarreraPOJO>();

                Conexion con = new Conexion();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM carrera");

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
        /// Busca y obtiene la carrera que coincida con el id ingresado
        /// como parámetro.
        /// </summary>
        /// <param name="id"></param>
        /// id utilizado para identificar la carrera.
        /// <returns>
        /// Retorna la carrera si es encontrada, de otro modo retorna null.
        /// </returns>
        public static CarreraPOJO ObtenerUno(int id)
        {
            try
            {
                Conexion con = new Conexion();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM carrera WHERE id = @P0");
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
        /// Construye una carrera con los datos ingresados como parámetro.
        /// </summary>
        /// <param name="dr"></param>
        /// Registro de datos pertenecientes a la carrera.
        /// <returns>
        /// Retorna la carrera creada.
        /// </returns>
        public static CarreraPOJO DataRowAObjeto(DataRow dr)
        {
            return new CarreraPOJO(
                int.Parse(dr["ID"].ToString()),
                dr["Nombre"].ToString()
            );
        }
    }
}
