using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using ResidenciasProfesionales.MODEL;
using ResidenciasProfesionales.DATA;
using System.Windows.Forms;

namespace ResidenciasProfesionales.VIEW
{
    public partial class FrmReporteResidencias : Form
    {
        public FrmReporteResidencias()
        {
            InitializeComponent();
            cargarDatos();
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
           
        }

        private void cargarDatos() {
            dgvLista.DataSource = null;
            List <DictamenPOJO> dictamenes = DictamenDAO.ObtenerProyectosTerminados();
            List<TablaResumenPOJO> tabla = new List<TablaResumenPOJO>();
            for (int i = 0; i < dictamenes.Count; i++) {
                TablaResumenPOJO elemento = new TablaResumenPOJO();
                DictamenPOJO dic = new DictamenPOJO();
                ResidenciaPOJO res = ResidenciaDAO.ObtenerResidencia(dictamenes[i].IdResidencia);
                List<DictamenPOJO> revisores = DictamenDAO.ObtenerDictamenesRevisores(res.ID);

                elemento.DictamenFinal = dictamenes[i].Estatus;
                elemento.Calificacion = dictamenes[i].Calificacion;

                elemento.Proyecto = res.NombreProyec;
                elemento.Empresa = EmpresaDAO.ObtenerEmpresa(res.IdEmpresa).Nombre;

                elemento.NombreAlumno = AlumnoDAO.ObtenerAlumno(res.IdAlumno).NombreCompleto;
                elemento.Matricula = res.IdAlumno;

                dic = DictamenDAO.ObtenerDictamenAsesor(res.ID);
                elemento.Asesor = DocenteDAO.ObtenerDocente(dic.IdDocente).NombreCompleto;
                elemento.DictamenAsesor = dic.Estatus;
                elemento.ComentarioAsesor = dic.Comentario;

                for (int j = 0; j < revisores.Count; j++) {
                    if (j == 0)
                    {
                        elemento.Revisor1 = DocenteDAO.ObtenerDocente(revisores[j].IdDocente).NombreCompleto;
                        elemento.DictamenRevisor1 = revisores[j].Estatus;
                        elemento.ComentarioRevisor1 = revisores[j].Comentario;
                    }
                    else
                    {
                        elemento.Revisor2 = DocenteDAO.ObtenerDocente(revisores[j].IdDocente).NombreCompleto;
                        elemento.DictamenRevisor2 = revisores[j].Estatus;
                        elemento.ComentarioRevisor2 = revisores[j].Comentario;
                    }
                }

                tabla.Add(elemento);
            }
            dgvLista.DataSource = tabla;
        }
    }
}
