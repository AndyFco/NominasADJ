﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class mostCargo : Form
    {
        public mostCargo()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Mostrar_Click(object sender, EventArgs e)
        {
            ConecxionDB c = new ConecxionDB();
            c.MostrarCargo(MostrarCargo, int.Parse(Codigo.Text));
            
        }
    }
}
