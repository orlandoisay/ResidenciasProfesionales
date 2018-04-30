using ResidenciasProfesionales.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResidenciasProfesionales.DATA
{
    public class InformeDAO
    {
        /// <summary>
        /// Obtiene la lista de informes por periodo.
        /// </summary>
        /// <param name="anio"></param>
        /// <param name="periodo"></param>
        /// <param name="aprobados"></param>
        /// <returns></returns>
        public static List<InformePOJO> ObtenerInformesPorPeriodo(int anio, string periodo, String idDocente, String rolDocente, bool aprobados)
        {
            try
            {
                var lista = new List<InformePOJO>();
                var alumnos = AlumnoDAO.ObtenerAlumnosPorDocente(idDocente);

                foreach (var alumno in alumnos)
                {
                    // Verifica la relacion de rol docente-alumno
                    var existeRol = RolDAO.ExisteRol(alumno.Matricula, idDocente, rolDocente);
                    if (!existeRol) continue;

                    var pre = aprobados ? "Liberacion" : "Aprobacion";
                    var responsables = DocenteDAO.ObtenerResponsablesDeAlumno(alumno.Matricula);

                    // No tiene asignados todos los responsables
                    if (responsables.Count < 3) continue;

                    InformePOJO.Dictamen dictamenAsesor, dictamenRevisor1, dictamenRevisor2;

                    var dicAsesor = DictamenDAO.ObtenerDictamen(responsables[0].ID, alumno.Matricula, pre + "Asesor");
                    var dicRevisor1 = DictamenDAO.ObtenerDictamen(responsables[1].ID, alumno.Matricula, pre + "Revisor");
                    var dicRevisor2 = DictamenDAO.ObtenerDictamen(responsables[2].ID, alumno.Matricula, pre + "Revisor");

                    // Asesor
                    if (dicAsesor == null)
                        dictamenAsesor = InformePOJO.Dictamen.PENDIENTE;
                    else if (dicAsesor.Estatus == "Aceptado")
                        dictamenAsesor = InformePOJO.Dictamen.APROBADO;
                    else
                        dictamenAsesor = InformePOJO.Dictamen.RECHAZADO;

                    // Revisor 1
                    if (dicRevisor1 == null)
                        dictamenRevisor1 = InformePOJO.Dictamen.PENDIENTE;
                    else if (dicRevisor1.Estatus == "Aceptado")
                        dictamenRevisor1 = InformePOJO.Dictamen.APROBADO;
                    else
                        dictamenRevisor1 = InformePOJO.Dictamen.RECHAZADO;

                    // Revisor 2
                    if (dicRevisor2 == null)
                        dictamenRevisor2 = InformePOJO.Dictamen.PENDIENTE;
                    else if (dicRevisor2.Estatus == "Aceptado")
                        dictamenRevisor2 = InformePOJO.Dictamen.APROBADO;
                    else
                        dictamenRevisor2 = InformePOJO.Dictamen.RECHAZADO;

                    lista.Add(
                        new InformePOJO(
                            alumno,
                            dictamenAsesor,
                            dictamenRevisor1,
                            dictamenRevisor2
                        )
                    );
                }

                return lista;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
