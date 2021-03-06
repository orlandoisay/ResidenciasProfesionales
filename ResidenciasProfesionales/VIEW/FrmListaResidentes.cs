﻿using ResidenciasProfesionales.DATA;
using ResidenciasProfesionales.MODEL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ResidenciasProfesionales.VIEW
{
    /// <summary>
    /// Lista las residencias en proceso para su posterior
    /// exportación.
    /// </summary>
    public partial class FrmListaResidentes : Form
    {
        // Almacena los datos con los cuales se llena la tabla.
        List<ListaPOJO> lista = new List<ListaPOJO>();

        /// <summary>
        /// Inicializa los componentes.
        /// </summary>
        public FrmListaResidentes()
        {
            InitializeComponent();
            cargarDatos();
        }

        /// <summary>
        /// Llena la tabla con los datos obtenidos a través de la
        /// consulta.
        /// </summary>
        private void cargarDatos() {
            dgvLista.DataSource = null;
            List<ResidenciaPOJO> residencias = ResidenciaDAO.ObtenerResidencias();
            if (residencias.Count > 0)
            {
                btnExportar.Enabled = true;
                for (int i = 0; i < residencias.Count; i++)
                {
                    // Crea un objeto de tipo ListaPOJO con los datos correspondientes.
                    ListaPOJO elemento = new ListaPOJO();
                    elemento.Matricula = residencias[i].IdAlumno;
                    elemento.NombreAlumno = AlumnoDAO.ObtenerAlumno(residencias[i].IdAlumno).NombreCompleto;
                    elemento.AsesorExt = residencias[i].AsesorExt;
                    elemento.Empresa = EmpresaDAO.ObtenerEmpresa(residencias[i].IdEmpresa).Nombre;
                    elemento.TelEmpresa = EmpresaDAO.ObtenerEmpresa(residencias[i].IdEmpresa).Telefono;
                    elemento.TelAlumno = AlumnoDAO.ObtenerAlumno(residencias[i].IdAlumno).Telefono;
                    elemento.CorreoAlumno = AlumnoDAO.ObtenerAlumno(residencias[i].IdAlumno).Correo;
                    elemento.AsesorInt = DocenteDAO.ObtenerDocenteXMatricula(residencias[i].IdAlumno).NombreCompleto;
                    elemento.CorreoAsesorInt = DocenteDAO.ObtenerDocenteXMatricula(residencias[i].IdAlumno).Correo;
                    elemento.Proyecto = residencias[i].NombreProyec;
                    lista.Add(elemento);
                }
                dgvLista.DataSource = lista;
            }
        }

        /// <summary>
        /// Exporta los datos de la lista a un archivo Excel.
        /// </summary>
        private void btnExportar_Click(object sender, EventArgs e)
        {
            // Inicializar el cuadro de diálogo
            sfdImpresion.FileName = string.Format("Lista de residentes");
            sfdImpresion.Filter = "Archivo de Excel (.xlsx)|*.xlsx";

            DialogResult dr = sfdImpresion.ShowDialog();

            if (dr != DialogResult.OK)
                return;

            bool resultado = ListaGenerador.GenerarFormatoDeReporte(lista, sfdImpresion.FileName);

            if (resultado)
                MessageBox.Show("Archivo generado corretamente", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Ocurrio un error al generar el archivo. Intente más tarde.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}