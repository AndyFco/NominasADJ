using System;
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
    public partial class marPrincipal : Form
    {
        public marPrincipal()
        {
            InitializeComponent();
        }

        private void show(object sender, EventArgs e)
        {

        }

        private void empleadoToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmEmpleado fe = new frmEmpleado();
            fe.Show();
        }

        private void departamentoToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmDepartamento fd = new frmDepartamento();
            fd.Show();
        }

        private void cargoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmCargo fc = new frmCargo();
            fc.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void empleadoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            mostEmpleado me = new mostEmpleado();
            me.Show();
        }

        private void departamentoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            mostDepartamento md = new mostDepartamento();
            md.Show();
        }

        private void cargoToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            mostCargo mc = new mostCargo();
            mc.Show();
        }
    }
}
