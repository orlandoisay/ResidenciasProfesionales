using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ResidenciasProfesionales.VIEW
{
    public partial class FrmControlDocumentacion : Form
    {
        public FrmControlDocumentacion()
        {
            InitializeComponent();
            insertarDocumentos();
        }

        public void insertarDocumentos() {
            tablaDocumentos.Rows.Add("Cronograma de actividades");
            tablaDocumentos.Rows.Add("Informe");
            tablaDocumentos.Rows.Add("Resumen ejecutivo");
            tablaDocumentos.Rows.Add("CD");
            tablaDocumentos.Rows.Add("Asesorias");
            tablaDocumentos.Rows.Add("Documento de evaluación");
        }
    }
}
