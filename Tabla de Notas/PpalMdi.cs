using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tabla_de_Notas
{
    public partial class PpalMdi : Form
    {
        public PpalMdi()
        {
            InitializeComponent();
        }

        private void estudiantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 ventanaestudiantes = new Form1();
            ventanaestudiantes.MdiParent = this;
            ventanaestudiantes.Show();
        }

        private void papeleraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 ventanaPapelera = new Form1();
            ventanaPapelera.MdiParent = this;
            ventanaPapelera.Show();
        }
    }
}
