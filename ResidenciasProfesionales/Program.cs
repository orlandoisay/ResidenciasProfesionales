﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ResidenciasProfesionales
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new VIEW.FrmVistaPrincipalCoordinador("CC0123456"));
            Application.Run(new VIEW.FrmLogin2());
        }
    }
}
