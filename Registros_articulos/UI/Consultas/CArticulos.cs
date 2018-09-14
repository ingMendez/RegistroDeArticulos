using Registros_articulos.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Windows.Forms;

namespace Registros_articulos.UI.Consultas
{
    public partial class CArticulos : Form
    {
        public CArticulos()
        {
            InitializeComponent();
        }

        private void Buscar_button_Click(object sender, EventArgs e)
        {
            Expression<Func<Articulos, bool>> filtro = a => true;
            int id;
            switch (Filtro_comboBox.SelectedIndex)
            {
                case 0: /// Todos
                         break;
                case 1: /// ArticulosId
                    id = Convert.ToInt32(Criterio_textBox.Text);
                    filtro = a => a.ArticuloId == id;
                    break;
                case 2: // Descripcion
                    filtro = a => a.Descripcion.Contains(Criterio_textBox.Text);
                    break;

                case 3: /// fecha
                    filtro = a => a.FechaVencimiento >=Desde_dateTimePicker.Value.Date && a.FechaVencimiento <=Hasta_dateTimePicker.Value.Date;
                    break;
                case 4: // descripcion y rango
                    filtro = a => (a.Descripcion.Contains(Criterio_textBox.Text)) && (a.FechaVencimiento >= Desde_dateTimePicker.Value.Date && a.FechaVencimiento <= Hasta_dateTimePicker.Value.Date);
                    break;

            }
            Consulta_dataGridView.DataSource = BLL.ArticulosBLL.GetList(filtro);
        }
    }
}
