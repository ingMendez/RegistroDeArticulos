using Registros_articulos.UI.Registros;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Registros_articulos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void ArticuloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rArticulos c = new rArticulos();
            c.ShowDialog();
           
        }

        private void articulosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rArticulos c = new rArticulos();
            c.ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rArticulos c = new rArticulos();
           
        }
    }
}
