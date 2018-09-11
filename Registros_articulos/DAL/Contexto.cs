using Registros_articulos.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace Registros_articulos.DAL
{
    public class Contexto:DbContext
    {
        public DbSet<Articulos> articulos { get; set;}

        public Contexto() : base("ConStr")
        {

        }
    }
}
