using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace semana_4_proyecto_de_juego_de_parejas_henry_sanchez
{
    public partial class Form1 : Form

    {
        
        Random random = new Random();

        
        List<string> icons = new List<string>()
      {
        "!", "!", "N", "N", ",", ",", "k", "k",
        "b", "b", "v", "v", "w", "w", "z", "z"
      };




        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
