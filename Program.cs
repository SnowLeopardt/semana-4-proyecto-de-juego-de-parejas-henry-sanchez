﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace semana_4_proyecto_de_juego_de_parejas_henry_sanchez
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
