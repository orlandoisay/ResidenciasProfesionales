using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResidenciasProfesionales.MODEL
{
    /// <summary>
    /// Objeto POJO de informe.
    /// </summary>
    /// <remarks>
    /// Permite manipular todos los atributos de un informe a través de un solo 
    /// objeto.
    /// </remarks>
    public class InformePOJO
    {
        // Getters y Setters.
        public enum Dictamen
        {
            APROBADO,
            RECHAZADO,
            PENDIENTE
        }

        public AlumnoPOJO Alumno { get; set; }
        public Dictamen DictamenAsesor { get; set; }
        public Dictamen DictamenRevisor1 { get; set; }
        public Dictamen DictamenRevisor2 { get; set; }

        /// <summary>
        /// Si hay al menos un dictamen pendiente, será pendiente.
        /// En caso contrario será igual al valor por mayoría.
        /// </summary>
        public Dictamen DictamenFinal
        {
            get
            {
                if (DictamenAsesor == Dictamen.PENDIENTE ||
                    DictamenRevisor1 == Dictamen.PENDIENTE ||
                    DictamenRevisor2 == Dictamen.PENDIENTE)
                    return Dictamen.PENDIENTE;

                int aprobados = (DictamenAsesor == Dictamen.APROBADO ? 1 : 0) +
                                (DictamenRevisor1 == Dictamen.APROBADO ? 1 : 0) +
                                (DictamenRevisor2 == Dictamen.APROBADO ? 1 : 0);

                return aprobados >= 2 ? Dictamen.APROBADO : Dictamen.RECHAZADO;
            }
        }
        public String AlumnoNombre
        {
            get
            {
                return Alumno.NombreCompleto;
            }
        }
        public String AlumnoMatricula
        {
            get
            {
                return Alumno.Matricula;
            }
        }

        // Constructor.
        public InformePOJO(AlumnoPOJO alumno, Dictamen dictamenAsesor, Dictamen dictamenRevisor1, Dictamen dictamenRevisor2)
        {
            Alumno = alumno;
            DictamenAsesor = dictamenAsesor;
            DictamenRevisor1 = dictamenRevisor1;
            DictamenRevisor2 = dictamenRevisor2;
        }
    }
}