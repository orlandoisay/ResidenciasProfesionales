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
            dgvTabla.AutoGenerateColumns = false;
            dgvTablaCarga.AutoGenerateColumns = false;
        }

        private void pPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pPanelV2_Paint(object sender, PaintEventArgs e)
        {

        }

        List<DocentePOJO> listRevisores;

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (indice != -1)
            {
                if (dgvTabla.Rows[indice].Cells[3].Value.ToString() == "")
                {
                    //
                    pPanel.Visible = false;
                    llenarDatos();
                    indice = -1;
                    pPanelV2.Location = new Point(pPanel.Location.X, pPanel.Location.Y);
                    pPanelV2.Size = new Size(939, 477);
                    pPanelV2.Visible = true;

                    //MessageBox.Show("Mal" + new RevisorDAO().ObtenerTodos().Count);
                    listRevisores = new RevisorDAO().ObtenerTodos();
                    dgvTablaCarga.DataSource = null;
                    dgvTablaCarga.DataSource = listRevisores;
                }
                else
                {
                    MessageBox.Show("Ya tiene revisores asignados.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1);
                }
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

        DocentePOJO d1 = null;
        DocentePOJO d2 = null;

        public bool verificar() {
            int cont = 0;
            int i = 0;
            foreach (DataGridViewRow row in dgvTablaCarga.Rows)
            {
                if (Convert.ToBoolean(row.Cells["cAceptar"].Value))
                {
                    cont++;
                    if (d1 == null)
                    {
                        d1 = listRevisores[i];
                    }
                    else if(d2 == null)
                    {
                        d2 = listRevisores[i];
                    }
                }
                i++;
            }
            return cont == 2;
        }

        List<TablaAsignacionRevisor> lista;

        private void FrmAsignacionRevisores_Load(object sender, EventArgs e)
        {
            AsignacionRevisorDAO ard = new AsignacionRevisorDAO();
            dgvTabla.DataSource = null;
            lista = ard.extraerList();
            dgvTabla.DataSource = lista;
        }

       

        private void dgvTabla_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indice = e.RowIndex;
        }

        string NoControl = "";

        private void llenarDatos() {
            NoControl = lista[indice].NoControl;
            AlumnoPOJO aP = AlumnoDAO.ObtenerAlumno(NoControl);
            lbNoControl.Text = aP.Matricula;
            lbNombre.Text = aP.NombreCompleto;
            lbCarrera.Text = aP.Carrera + "";
            lbSemestre.Text = aP.Semestre + "";
            Asesor asesor = new AsesorDAO().ObtenerAsesor(lista[indice].IdAsesor);
            lbCarreraAS.Text = asesor.Carrera;
            lbNombreAS.Text = asesor.NombreCompleto;
        }

        private void dgvTabla_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAsignarContinuar_Click(object sender, EventArgs e)
        {
            insertarRevisores();
        }

        public void insertarRevisores() {
            if (verificar())
            {
                RevisorDAO.InsertarRevisor(NoControl, d1.ID, d2.ID);
                MessageBox.Show("Datos guardados.",
               "Aviso",
               MessageBoxButtons.OK,
               MessageBoxIcon.Information,
               MessageBoxDefaultButton.Button1);
            }
            else
            {
                MessageBox.Show("Selecciona dos revisores.",
                "Aviso",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button1);
            }
        }

        public void regresar() {
            AsignacionRevisorDAO ard = new AsignacionRevisorDAO();
            lista = ard.extraerList();
            dgvTabla.DataSource = null;
            dgvTabla.DataSource = lista;
            pPanel.Visible = true;
            pPanelV2.Visible = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            regresar();
        }

        private void btnAsignar_Click(object sender, EventArgs e)
        {
            insertarRevisores();
            regresar();
        }
    }
}
