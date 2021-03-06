﻿using MySql.Data.MySqlClient;
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
    /// Objeto de acceso a datos de empresa.
    /// </summary>
    /// <remarks>
    /// Permite acceder a los datos almacenados de la empresa.
    /// </remarks>
    public class EmpresaDAO
    {
        /// <summary>
        /// Busca y obtiene a la empresa que coincida con el rfc ingresado
        /// como parámetro.
        /// </summary>
        /// <param name="rfc"></param>
        /// RFC utilizado para identificar a la empresa.
        /// <returns>
        /// Retorna la empresa si es encontrada, de otro modo retorna null.
        /// </returns>
        public static EmpresaPOJO ObtenerEmpresa(string rfc)
        {
            try
            {
                Conexion con = new Conexion();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM empresa WHERE rfc = @P0");
                cmd.Parameters.AddWithValue("@P0", rfc);

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
        /// Inserta una nueva empresa en la base de datos.
        /// </summary>
        /// <param name="empresa"></param>
        /// Contiene los datos que constituyen a una empresa.
        /// <returns>
        /// Retorna -1 si la sentencia no se ejecuto correctamente.
        /// </returns>
        public static int InsertarEmpresa(EmpresaPOJO empresa)
        {
            try
            {
                Conexion con = new Conexion();
                MySqlCommand cmd = new MySqlCommand("INSERT INTO empresa VALUES(@P0,@P1,@P2,@P3,@P4,@P5,@P6,@P7,@P8,@P9,@P10,@P11,@P12);");
                cmd.Parameters.AddWithValue("@P0", empresa.RFC);
                cmd.Parameters.AddWithValue("@P1", empresa.Nombre);
                cmd.Parameters.AddWithValue("@P2", empresa.Giro);
                cmd.Parameters.AddWithValue("@P3", empresa.Sector);
                cmd.Parameters.AddWithValue("@P4", empresa.Domicilio);
                cmd.Parameters.AddWithValue("@P5", empresa.Colonia);
                cmd.Parameters.AddWithValue("@P6", empresa.Ciudad);
                cmd.Parameters.AddWithValue("@P7", empresa.CP);
                cmd.Parameters.AddWithValue("@P8", empresa.Telefono);
                cmd.Parameters.AddWithValue("@P9", empresa.Fax);
                cmd.Parameters.AddWithValue("@P10", empresa.Mision);
                cmd.Parameters.AddWithValue("@P11", empresa.Titular);
                cmd.Parameters.AddWithValue("@P12", empresa.PuestoTit);

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
        /// Remplaza a la empresa ubicada en la base de datos por la
        /// empresa ingresada como parametro.
        /// </summary>
        /// <param name="empresa"></param>
        /// Contiene los datos de la empresa que remplazará a la empresa 
        /// almacenada.
        /// /// <returns>
        /// Retorna true si la inserción se ejecuto correctamente, de otro
        /// modo retorna false.
        /// </returns>
        public static bool ActualizarEmpresa(EmpresaPOJO empresa)
        {
            try
            {
                Conexion con = new Conexion();
                MySqlCommand cmd = new MySqlCommand("UPDATE empresa SET Nombre=@P1, Giro=@P2, Sector=@P3, " +
                    "Domicilio=@P4, Colonia=@P5, Ciudad=@P6, CP=@P7, Telefono=@P8, Fax=@P9, Mision=@P10, " +
                    "Titular=@P11, PuestoTitu=@P12 WHERE RFC=@P0");
                cmd.Parameters.AddWithValue("@P0", empresa.RFC);
                cmd.Parameters.AddWithValue("@P1", empresa.Nombre);
                cmd.Parameters.AddWithValue("@P2", empresa.Giro);
                cmd.Parameters.AddWithValue("@P3", empresa.Sector);
                cmd.Parameters.AddWithValue("@P4", empresa.Domicilio);
                cmd.Parameters.AddWithValue("@P5", empresa.Colonia);
                cmd.Parameters.AddWithValue("@P6", empresa.Ciudad);
                cmd.Parameters.AddWithValue("@P7", empresa.CP);
                cmd.Parameters.AddWithValue("@P8", empresa.Telefono);
                cmd.Parameters.AddWithValue("@P9", empresa.Fax);
                cmd.Parameters.AddWithValue("@P10", empresa.Mision);
                cmd.Parameters.AddWithValue("@P11", empresa.Titular);
                cmd.Parameters.AddWithValue("@P12", empresa.PuestoTit);

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
        /// Busca y elimina a la empresa que coincida con el rfc ingresado
        /// como parámetro.
        /// </summary>
        /// <param name="RFC"></param>
        /// RFC utilizado para identificar a la empresa.
        /// <returns>
        /// Retorna true si la empresa se elimino correctamente, si no es 
        /// así retorna false.
        /// </returns>
        public static bool EliminarEmpresa(String RFC)
        {
            try
            {
                Conexion con = new Conexion();
                MySqlCommand cmd = new MySqlCommand("DELETE FROM empresa WHERE RFC=@P0");
                cmd.Parameters.AddWithValue("@P0", RFC);

                con.ejecutarSentencia(cmd, false);

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
        /// Construye una empresa con los datos ingresados como parámetro.
        /// </summary>
        /// <param name="dr"></param>
        /// Registro de datos pertenecientes a la empresa.
        /// <returns>
        /// Retorna la empresa creada.
        /// </returns>
        public static EmpresaPOJO DataRowAObjeto(DataRow dr)
        {
            return new EmpresaPOJO(
                dr["RFC"].ToString(),
                dr["Nombre"].ToString(),
                dr["Giro"].ToString(),
                dr["Sector"].ToString(),
                dr["Domicilio"].ToString(),
                dr["Colonia"].ToString(),
                dr["Ciudad"].ToString(),
                dr["CP"].ToString(),
                dr["Telefono"].ToString(),
                dr["Fax"].ToString(),
                dr["Mision"].ToString(),
                dr["Titular"].ToString(),
                dr["PuestoTitu"].ToString()
            );
        }

    }
}
