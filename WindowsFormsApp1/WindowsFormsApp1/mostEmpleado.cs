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
    public partial class mostEmpleado : Form
    {
        public mostEmpleado()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Mostrar_Click(object sender, EventArgs e)
        {
            ConecxionDB c = new ConecxionDB();
            c.MostrarEmpleado(infoEmpleado, int.Parse(Codigo.Text));
        }
    }
}
