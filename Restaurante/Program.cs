﻿using Restaurante.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurante
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        // ← Referência global ao Form1
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new TelaPrincipal());

        }

        
    }
}
