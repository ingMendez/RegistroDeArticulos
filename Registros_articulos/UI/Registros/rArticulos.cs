using Registros_articulos.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Registros_articulos.UI.Registros
{
    public partial class rArticulos : Form
    {
        public rArticulos()
        {
            InitializeComponent();
        }
        private bool GuardarValidar()
        {
            bool paso = true;

            if (string.IsNullOrWhiteSpace(Descripcion_textBox.Text))
            {
                MessageBox.Show("Debe Llenar el campo ");
                paso = false;
            }
            if (FechaVencimiento_dateTimePicker.Value != DateTime.Now && FechaVencimiento_dateTimePicker.Value < DateTime.Now)
            {
                MessageBox.Show("debe seleccionar una fecha mayor a la actual");
                paso = false;
            }

            if (Precio_numericUpDown.Value == 0)
            {
                MessageBox.Show("Falto Digitar el precio del articulo");
                paso = false;
            }
            if (Existencia_numericUpDown.Value == 0)
            {
                MessageBox.Show("Falto digitar la Existencia");
                paso = false;
            }
            if(CantidadCotizada_numericUpDown.Value == 0)
            {
                MessageBox.Show("Falto digitar la cotizacion");
                paso = false;
            }


        }
         
    

        private Articulos LlenaClase()
        {
            Articulos articulo = new Articulos();

            articulo.ArticuloId = Convert.ToInt32(ArticuloId_numericUpDown.Value);
            articulo.FechaVencimiento = FechaVencimiento_dateTimePicker.Value;
            articulo.Descripcion = Descripcion_textBox.Text;
            articulo.precio = Convert.ToInt32(Precio_numericUpDown.Value);
            articulo.Existencia = Convert.ToInt32(Existencia_numericUpDown.Value);
            articulo.cantCotizada = Convert.ToInt32(CantidadCotizada_numericUpDown.Value);

            return articulo;
        }

        private void Nuevo_button_Click(object sender, EventArgs e)
        {
            ArticuloId_numericUpDown.Value = 0;
            FechaVencimiento_dateTimePicker.ResetText();
            Descripcion_textBox.Clear();
            Precio_numericUpDown.Value = 0;
            Existencia_numericUpDown.Value = 0;
            CantidadCotizada_numericUpDown.Value = 0;
           
        }

        private void Guardar_button_Click(object sender, EventArgs e)
        {
            Articulos articulos = LlenaClase();
            bool paso = false;
            
            if(Validar()) ///sim la funcion validar = true entonces guardaame
            {
                
            }

        }
    }
}
