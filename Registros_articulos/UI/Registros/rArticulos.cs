using Registros_articulos.BLL;
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
          //  if (string.IsNullOrWhiteSpace(Descripcion_textBox.Text)||(FechaVencimiento_dateTimePicker.Value != DateTime.Now && FechaVencimiento_dateTimePicker.Value < DateTime.Now )|| Precio_numericUpDown.Value ==0 ||Existencia_numericUpDown.Value ==0||(CantidadCotizada_numericUpDown.Value == 0 ||(CantidadCotizada_numericUpDown.Value > Existencia_numericUpDown.Value)));

            if (string.IsNullOrWhiteSpace(Descripcion_textBox.Text))
            {
               SuperErrorProvider.SetError(Descripcion_textBox,"Debe Llenar el campo ");
                paso = false;
            }
            if (FechaVencimiento_dateTimePicker.Value != DateTime.Now && FechaVencimiento_dateTimePicker.Value < DateTime.Now)
            {
                SuperErrorProvider.SetError(FechaVencimiento_dateTimePicker,"debe seleccionar una fecha mayor a la actual");
                paso = false;
            }
            if (Precio_numericUpDown.Value == 0)
            {
               SuperErrorProvider.SetError(Precio_numericUpDown,"Falto Digitar el precio del articulo");
               paso = false;
            }
            if (Existencia_numericUpDown.Value == 0)
            {
               SuperErrorProvider.SetError(Existencia_numericUpDown,"Falto digitar la Existencia");
               paso = false;
            }
            if(CantidadCotizada_numericUpDown.Value == 0)
            {
               SuperErrorProvider.SetError(CantidadCotizada_numericUpDown,"Falto digitar la cotizacion");
               paso = false;
            }
            else
            if(CantidadCotizada_numericUpDown.Value >Existencia_numericUpDown.Value)
            {
                MessageBox.Show("la cantidad cotizada no puede superar a la Existencia");
            }
            return paso;
        }
        private void Limpiar()
        {
            ArticuloId_numericUpDown.Value = 0;
            FechaVencimiento_dateTimePicker.ResetText();
            Descripcion_textBox.Clear();
            Precio_numericUpDown.Value = 0;
            CantidadCotizada_numericUpDown.Value = 0;
            Existencia_numericUpDown.Value = 0;
            
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
        private Articulos LlenaCampo(Articulos articulos)
        {
       //     articulos.ArticuloId = Convert.ToInt32(ArticuloId_numericUpDown.Value);
            FechaVencimiento_dateTimePicker.Value = articulos.FechaVencimiento;
             Descripcion_textBox.Text = articulos.Descripcion;
             Convert.ToInt32(Precio_numericUpDown.Value = articulos.precio);
         Convert.ToInt32(Existencia_numericUpDown.Value = articulos.Existencia);
          Convert.ToInt32(CantidadCotizada_numericUpDown.Value = articulos.cantCotizada);
            return articulos;
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
            SuperErrorProvider.Clear();
            int id = (int)ArticuloId_numericUpDown.Value;
            Articulos articulos = ArticulosBLL.Buscar(id);
            Articulos articulos_guardar = LlenaClase();
            
            if (articulos == null)
            {
                if (GuardarValidar()) ///sim la funcion validar = true entonces guardaame
                {
                    if (ArticulosBLL.Guardar(articulos_guardar))
                    {
                        MessageBox.Show("Articulo Guardado");
                        Limpiar();

                    }
                }
            }
            else
            {
                if (GuardarValidar())
                {
                    if (ArticulosBLL.Modificar(articulos_guardar))
                        MessageBox.Show("articulo Modificado");
                    else
                        MessageBox.Show("Articulo no medificado");
                }



            }
            
        }

        private void Eliminar_button_Click(object sender, EventArgs e)
        {
            SuperErrorProvider.Clear();
            int id;
            int.TryParse(ArticuloId_numericUpDown.Text, out id);
            Articulos articulos = BLL.ArticulosBLL.Buscar(id);
            if(articulos != null)
            {
                BLL.ArticulosBLL.Eliminar(id);
                MessageBox.Show("Articulos Eliminado");
                Limpiar();

            }
            else
            {
                MessageBox.Show("No se puede eliminar un libro que no existe", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error );
                Nuevo_button.PerformClick();
            }
        }

        private void Buscar_button_Click(object sender, EventArgs e)
        {
            SuperErrorProvider.Clear();
            int id;
            Articulos articulos =new Articulos();
            int.TryParse(ArticuloId_numericUpDown.Text, out id);
            articulos = ArticulosBLL.Buscar(id);
            if(articulos != null)
            {
                MessageBox.Show("articulo encontrado");
                LlenaCampo(articulos);

            }
            else
            {
                MessageBox.Show("articulo no encontrado");      
            }
          
        }
    }
}
