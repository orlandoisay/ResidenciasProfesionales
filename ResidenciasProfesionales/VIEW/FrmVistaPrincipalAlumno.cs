using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ResidenciasProfesionales.MODEL;
using ResidenciasProfesionales.DATA;

namespace ResidenciasProfesionales.VIEW
{
    public partial class FrmVistaPrincipalAlumno : Form
    {
        String idAlumno;
        public FrmVistaPrincipalAlumno(String idAlumno)
        {
            InitializeComponent();
            this.idAlumno = idAlumno;
        }

        private void btnVerSolicitud_Click(object sender, EventArgs e)
        {
            var frmSolicitud = new FrmSolicitud(idAlumno);
            frmSolicitud.ShowDialog();
        }
    }
}
