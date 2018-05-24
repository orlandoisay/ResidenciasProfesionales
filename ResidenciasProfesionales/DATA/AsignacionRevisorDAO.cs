using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using ResidenciasProfesionales.MODEL;

namespace ResidenciasProfesionales.DATA
{
    /// <summary>
    /// Clase encargada de obtener las asignaciones de revisores.
    /// </summary>
    /// <remarks>
    /// Llena las listas necesarias para producir las asignaciones
    /// de revisores.
    /// </remarks>
    class AsignacionRevisorDAO
    {
        // Listas globales.
        List<aux> listaRevisores = new List<aux>();
        List<MAA> listaMAA = new List<MAA>();

        // Constructor.
        public AsignacionRevisorDAO() {
            llenarListaMAA();
        }

        /// <summary>
        /// Llena la lista listaMAA con los datos recopilados a través de la 
        /// consulta.
        /// </summary>
        public void llenarListaMAA() {
            try
            {
                Conexion con = new Conexion();
                MySqlCommand cmd = new MySqlCommand("select a.Matricula, concat(a.ApellidoP,' ',a.ApellidoM,', ',a.Nombre)as Alumno,rd.IdDocente,concat(d.ApellidoP,' ',d.ApellidoM,' ',d.Nombre)as Asesor from alumno a join roldocente rd on a.Matricula = rd.IdAlumno join docente d on rd.IdDocente = d.ID where rd.Rol = 'Asesor' order by Matricula;");

                DataTable dt = con.ejecutarConsulta(cmd);

                foreach (DataRow dr in dt.Rows)
                {
                    listaMAA.Add(new MAA(dr["Matricula"].ToString(), dr["Alumno"].ToString(),dr["IdDocente"].ToString(), dr["Asesor"].ToString()));
                }
                llenarListaRevisores();
                return;
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
        /// Llena la lista listaRevisores con los datos recopilados a través 
        /// de la consulta.
        /// </summary>
        public void llenarListaRevisores() {
            try
            {
                Conexion con = new Conexion();
                MySqlCommand cmd = new MySqlCommand("select a.Matricula, concat(d.ApellidoP,' ',d.ApellidoM,' ',d.Nombre) as Revisor from alumno a join roldocente rd on a.Matricula = rd.IdAlumno join docente d on rd.IdDocente = d.ID where rd.Rol = 'Revisor' order by Matricula;");

                DataTable dt = con.ejecutarConsulta(cmd);

                foreach (DataRow dr in dt.Rows) {
                    listaRevisores.Add(new aux(dr["Matricula"].ToString(), dr["Revisor"].ToString()));
                }
                crearTabla();
                return;
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

        // Lista global.
        List<TablaAsignacionRevisor> list;
        
        // Getter.
        public List<TablaAsignacionRevisor> extraerList() {
            return list;
        }

        /// <summary>
        /// Llena la lista list con las asignaciones de revisores producidas 
        /// a través de un ciclo.
        /// </summary>
        public List<TablaAsignacionRevisor> crearTabla() {
            list = new List<TablaAsignacionRevisor>();
            string rev1 = "", rev2 = "";

            for (int i = 0; i < listaMAA.Count; i++) {
                for (int j = 0; j < listaRevisores.Count; j++) {
                    if (listaMAA[i].Matricula == listaRevisores[j].Matricula) {
                        if (rev1 == "")
                        {
                            rev1 = listaRevisores[j].Revisor;
                        }
                        else if (rev2 == "")
                        {
                            rev2 = listaRevisores[j].Revisor;
                        }
                        else {
                            break;
                        }
                    }
                }
                list.Add(new TablaAsignacionRevisor(listaMAA[i],rev1,rev2));
                rev1 = "";
                rev2 = "";
            }
            return list;
        }
    }
    /// <summary>
    /// Clase auxiliar para establecer la relación alumno-revisor.
    /// </summary>
    class aux
    {
        // Getters y Setters.
        public string Matricula { get; set; }
        public string Revisor { get; set; }

        // Constructor.
        public aux(string matricula, string revisor)
        {
            Matricula = matricula;
            Revisor = revisor;
        }

    }

}
