using Registros_articulos.UI.Consultas;
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
    public partial class sistemaArticulos : Form
    {
        public sistemaArticulos()
        {
            InitializeComponent();
        }

       


        private void ArticuloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rArticulos c = new rArticulos();
            c.ShowDialog();
           
        }

        private void articulosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CArticulos c = new CArticulos();
            c.ShowDialog();
            
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            Close();
           
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
    }
}
