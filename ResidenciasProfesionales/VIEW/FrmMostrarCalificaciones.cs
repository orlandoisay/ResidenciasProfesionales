using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ResidenciasProfesionales.VIEW
{
    public partial class FrmMostrarCalificaciones : Form
    {
        String idDocente;
        public FrmMostrarCalificaciones(String ID)
        {
            InitializeComponent();
            idDocente = ID;
        }
    }
}
