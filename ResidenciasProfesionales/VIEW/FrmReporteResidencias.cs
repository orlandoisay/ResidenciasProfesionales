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
                elemento.Proyecto = res.NombreProyec;
                elemento.Empresa = EmpresaDAO.ObtenerEmpresa(res.IdEmpresa).Nombre;

                dic = DictamenDAO.ObtenerDictamenAsesor(res.ID);
                //elemento.Asesor = 
            }
            dgvLista.DataSource = DictamenDAO.ObtenerProyectosTerminados();
        }
    }
}
