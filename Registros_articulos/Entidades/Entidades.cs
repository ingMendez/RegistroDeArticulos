using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Registros_articulos.Entidades
{
   public class Articulos
    {
        [Key]
        public int ArticuloId { get; set;}

        public DateTime  FechaVencimiento { get; set; }

        public string   Descripcion { get; set; }

        public int precio { get; set; }

        public int Existencia { get; set; }

        public int cantCotizada { get; set; }

        public Articulos()
        {
            ArticuloId = 0;
            FechaVencimiento = DateTime.Now;
            Descripcion = string.Empty;
            precio = 0;
            Existencia = 0;
            cantCotizada = 0;
            

        }
    }
}
