using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ResidenciasProfesionales.DATA;
using ResidenciasProfesionales.MODEL;

namespace ResidenciasProfesionales.VIEW
{
    public partial class FrmAsignacionRevisores : Form
    {
        int indice = -1;
        public FrmAsignacionRevisores()
        {
            InitializeComponent();
            this.Size = new Size(958, 518);
            //939, 477
            pPanel.Size = new Size(939, 477);
            pPanelV2.Visible = false;
        }

        private void pPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pPanelV2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (indice != -1)
            {
                //
                pPanel.Visible = false;
                llenarDatos();
                indice = -1;
                pPanelV2.Location = new Point(pPanel.Location.X, pPanel.Location.Y);
                pPanelV2.Size = new Size(939, 477);
                pPanelV2.Visible = true;

            }
            else
            {
                MessageBox.Show("Seleciona una fila.",
                 "Aviso",
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Information,
                 MessageBoxDefaultButton.Button1);
            }
        }

        List<TablaAsignacionRevisor> lista;

        private void FrmAsignacionRevisores_Load(object sender, EventArgs e)
        {
            AsignacionRevisorDAO ard = new AsignacionRevisorDAO();
            lista = ard.extraerList();
            dgvTabla.DataSource = lista;
        }

       

        private void dgvTabla_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indice = e.RowIndex;
        }

        private void llenarDatos() {
            AlumnoPOJO aP = new AlumnoDAO().ObtenerAlumno(lista[indice].NoControl);
            lbNoControl.Text = aP.Matricula;
            lbNombre.Text = aP.Nombre;
            lbCarrera.Text = aP.Carrera + "";
            lbSemestre.Text = aP.Semestre + "";
            Asesor asesor = new AsesorDAO().ObtenerAsesor(lista[indice].IdAsesor);
            MessageBox.Show(asesor.Carrera);
            lbCarreraAS.Text = asesor.Carrera;
            lbNombreAS.Text = asesor.Nombre;
        }
    }
}
