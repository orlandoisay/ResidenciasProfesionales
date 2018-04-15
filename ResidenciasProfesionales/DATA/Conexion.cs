using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace ResidenciasProfesionales.DATA
{
    class Conexion
    {
        public static MySqlConnection conexion = null;

        static public bool Conectar()
        {
            String parametrosConexion = "Server=127.0.0.1;Database=ControlResidencias;Uid=root;Pwd=root;Port=3306;";
            conexion = new MySqlConnection(parametrosConexion);
            //Intentamos conectarnos
            try
            {
                conexion.Open();
                return true;
            }
            catch (Exception ex)
            {
                //throw ex;
                return false;
            }

        }

        public DataTable ejecutarConsulta(MySqlCommand com)
        {
            try
            {
                if (Conectar())
                {
                    com.Connection = conexion;
                    MySqlDataAdapter objAdapter =
                        new MySqlDataAdapter(com);
                    DataTable resultado = new DataTable();
                    //LLenar el objeto con el resultado de la consulta
                    objAdapter.Fill(resultado);
                    return resultado;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                //Solo intentar cerrar la conexión cuando si se encuentra abierta
                if (conexion != null)
                    conexion.Close();
            }

        }
        //new MySqlCommand(sentencia, conexion);
        /// <summary>
        /// Ejecuta una sentencia en la base de datos
        /// </summary>
        /// <param name="sentencia"></param>
        /// <param name="esInsert"></param>
        /// <returns></returns>
        public int ejecutarSentencia(MySqlCommand objComando, bool esInsert)
        {
            int resultado = 0;
            try
            {
                if (Conectar())
                {
                    objComando.Connection = conexion;
                    MySqlDataAdapter objAdapter =
                       new MySqlDataAdapter(objComando);
                    if (esInsert)
                    {
                        //Obtiene el último id ingresado por el insert
                        resultado = int.Parse(objComando.ExecuteScalar().ToString());
                    }
                    else
                    {
                        objComando.ExecuteNonQuery();
                        resultado = 1;
                    }


                    return resultado;
                }
                else
                {
                    return 0;
                }
            }
            catch (Exception ex)
            {
                return 0;
            }
            finally
            {
                if (conexion != null)
                    conexion.Close();
            }
        }
    }
}

