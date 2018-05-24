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
    /// <summary>
    /// Clase encargada de asignar revisores a los alumnos.
    /// </summary>
    public partial class FrmAsignacionRevisores : Form
    {
        int indice = -1;

        /// <summary>
        /// Inicializa los componentes.
        /// </summary>
        public FrmAsignacionRevisores()
        {
            InitializeComponent();
            this.Size = new Size(958, 518);
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

        // Almacena a todos los revisores.
        List<DocentePOJO> listRevisores;
        private bool borrar = true;
        /// <summary>
        /// Despliega el panel encargado de mostrar los revisores
        /// disponibles.
        /// </summary>
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (indice != -1)
            {
                
                if (dgvTabla.Rows[indice].Cells[3].Value.ToString() == "")
                {
                    borrar = false;
                }
                String revisor1, revisor2;
                revisor1 = dgvTabla.Rows[indice].Cells[3].Value.ToString();
                revisor2 = dgvTabla.Rows[indice].Cells[4].Value.ToString();
                    pPanel.Visible = false;
                    llenarDatos();
                    indice = -1;
                    pPanelV2.Location = new Point(pPanel.Location.X, pPanel.Location.Y);
                    pPanelV2.Size = new Size(939, 477);
                    pPanelV2.Visible = true;
                    listRevisores = new RevisorDAO().ObtenerTodos();
                    dgvTablaCarga.DataSource = null;
                    dgvTablaCarga.DataSource = listRevisores;
                for (int i = 0; i < dgvTablaCarga.RowCount; i++)
                {
                    if (revisor1 == dgvTablaCarga.Rows[i].Cells[1].Value.ToString()) {
                        dgvTablaCarga.Rows[i].Cells[0].Value = true;
                    }
                    else if (revisor2 == dgvTablaCarga.Rows[i].Cells[1].Value.ToString())
                    {
                        dgvTablaCarga.Rows[i].Cells[0].Value = true;
                    }
                }
                /*}
                else
                {
                    MessageBox.Show("Ya tiene revisores asignados.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1);
                }*/
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

        /// <summary>
        /// Verifica si existen dos revisores seleccionados.
        /// </summary>
        /// <returns>
        /// Retorna true si seleccionaron exactamente dos revisores,
        /// de otro modo retorna false.
        /// </returns>
        public bool verificar() {
            int cont = 0;
            int i = 0;
            d1 = d2 = null;
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

        // Almacena los datos usados para llenar la tabla de revisores.
        List<TablaAsignacionRevisor> lista;

        /// <summary>
        /// Llama al método encargado de actualizar la tabla.
        /// </summary>
        private void FrmAsignacionRevisores_Load(object sender, EventArgs e)
        {
            actualizarDgvTabla();
        }

        /// <summary>
        /// Actualiza la tabla de revisores.
        /// </summary>
        public void actualizarDgvTabla() {
            AsignacionRevisorDAO ard = new AsignacionRevisorDAO();
            dgvTabla.DataSource = null;
            lista = ard.extraerList();
            dgvTabla.DataSource = lista;
        }

        /// <summary>
        /// Evento capaz de reconocer la fila seleccionada.
        /// </summary>
        private void dgvTabla_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indice = e.RowIndex;
        }

        string NoControl = "";

        /// <summary>
        /// Llena los componentes encargados de mostrar los datos del docente
        /// y del alumno seleccionado.
        /// </summary>
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

        /// <summary>
        /// Llama al método encargado de asignarle los revisores
        /// seleccionados al alumno.
        /// </summary>
        private void btnAsignarContinuar_Click(object sender, EventArgs e)
        {
            insertarRevisores();
            siguiente();
        }

        /// <summary>
        /// Permite desplazarse al siguiente alumno sin revisores
        /// asignados.
        /// </summary>
        public void siguiente() {
            actualizarDgvTabla();
            bool entrar = false;
            for (int i = 0; i < dgvTabla.RowCount; i++) {
                if (dgvTabla.Rows[i].Cells[3].Value.ToString() == "") {
                    entrar = true;
                    indice = i;
                    llenarDatos();
                    indice = -1;
                    listRevisores = new RevisorDAO().ObtenerTodos();
                    dgvTablaCarga.DataSource = null;
                    dgvTablaCarga.DataSource = listRevisores;
                }
            }
            if (!entrar)
            {
                RevisorDAO.InsertarRevisor(NoControl, d1.ID, d2.ID);
                MessageBox.Show("No hay más alumnos sin revisores.",
               "Aviso",
               MessageBoxButtons.OK,
               MessageBoxIcon.Information,
               MessageBoxDefaultButton.Button1);
                regresar();
            }
        }

        /// <summary>
        /// Revisa si se han seleccionado dos revisores, de ser
        /// así permite ingresarlos como revisores del alumno
        /// a la base de datos.
        /// </summary>
        public void insertarRevisores() {
            if (verificar())
            {
                if (borrar) {
                    RevisorDAO.EliminarRevisor(NoControl);
                    MessageBox.Show("//");
                }
                RevisorDAO.InsertarRevisor(NoControl, d1.ID, d2.ID);
                MessageBox.Show(d1.Nombre + " " + d2.Nombre);
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

        /// <summary>
        /// Inicializa los valores después de un cambio.
        /// </summary>
        public void regresar() {
            AsignacionRevisorDAO ard = new AsignacionRevisorDAO();
            lista = ard.extraerList();
            dgvTabla.DataSource = null;
            dgvTabla.DataSource = lista;
            pPanel.Visible = true;
            pPanelV2.Visible = false;
        }

        /// <summary>
        /// Descarta cualquier cambio y regresa la lista de alumnos.
        /// </summary>
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            regresar();
        }

        /// <summary>
        /// Llama al método encargado de asignarle los revisores
        /// seleccionados al alumno.
        /// </summary>
        private void btnAsignar_Click(object sender, EventArgs e)
        {
            insertarRevisores();
            regresar();
        }

        /// <summary>
        /// Cierra la ventana actual.
        /// </summary>
        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}