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
    public class SolicitudDAO
    {
        public static List<SolicitudPOJO> ObtenerTodos()
        {
            try
            {
                var list = new List<SolicitudPOJO>();

                Conexion con = new Conexion();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM solicitud");

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
        public static SolicitudPOJO ObtenerSolicitud(int id)
        {
            try
            {
                Conexion con = new Conexion();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM solicitud WHERE id = @P0");
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

        public static List<SolicitudPOJO> ObtenerSolicitudesPendientes()
        {
            try
            {
                var list = new List<SolicitudPOJO>();

                Conexion con = new Conexion();
                MySqlCommand cmd = new MySqlCommand("SELECT s.id, s.idAlumno, s.idResidencia FROM solicitud s, alumno a WHERE a.matricula = s.idAlumno and a.estatus like 'Pendiente'");

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

        public static SolicitudPOJO DataRowAObjeto(DataRow dr)
        {
            return new SolicitudPOJO(
                int.Parse(dr["id"].ToString()),
                dr["idAlumno"].ToString(),
                int.Parse(dr["idResidencia"].ToString())
            );
        }
    }
}