using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResidenciasProfesionales.MODEL
{
    public class InformePOJO
    {
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

                int aprobados = (DictamenAsesor == Dictamen.PENDIENTE ? 1 : 0) +
                                (DictamenRevisor1 == Dictamen.PENDIENTE ? 1 : 0) +
                                (DictamenRevisor2 == Dictamen.PENDIENTE ? 1 : 0);

                return aprobados >= 2 ? Dictamen.APROBADO : Dictamen.RECHAZADO;
            }
        }

        public InformePOJO() { }

        public InformePOJO(AlumnoPOJO alumno, Dictamen dictamenRevisor1, Dictamen dictamenRevisor2)
        {
            Alumno = alumno;
            DictamenRevisor1 = dictamenRevisor1;
            DictamenRevisor2 = dictamenRevisor2;
        }
    }
}
