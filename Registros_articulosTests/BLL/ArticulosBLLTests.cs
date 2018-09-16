using Microsoft.VisualStudio.TestTools.UnitTesting;
using Registros_articulos.BLL;
using Registros_articulos.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
//using Registros_articulos.Entidades;
using Registros_articulos.DAL;
using System.Text;

namespace Registros_articulos.BLL.Tests
{
    [TestClass()]
    public class ArticulosBLLTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            bool paso;
            Articulos articulo = new Articulos();
            articulo.ArticuloId = 0;
            articulo.FechaVencimiento = Convert.ToDateTime(value: "12-10-2018");
            articulo.Descripcion = "lata de guadules";
            articulo.Existencia = 60;
            articulo.cantCotizada = 50;
            paso = BLL.ArticulosBLL.Guardar(articulo);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void ModificarTest()
        {
            bool paso;
            Articulos articulo = new Articulos();
            articulo.ArticuloId =5;
            articulo.Descripcion = "lata de guandules";
            articulo.Existencia = 100;
            articulo.cantCotizada = 15;
            paso = BLL.ArticulosBLL.Modificar(articulo);
            Assert.AreEqual(paso,true);
        }

        [TestMethod()]
        public void EliminarTest()
        {
            bool paso;
            paso = BLL.ArticulosBLL.Eliminar(3);

            Assert.AreEqual(paso,true);
        }

        [TestMethod()]
        public void BuscarTest()
        {
            Articulos articulo = new Articulos();

            articulo = BLL.ArticulosBLL.Buscar(5);
            Assert.IsNotNull(articulo);
        }

        [TestMethod()]
        public void GetListTest()
        {
            var lista = BLL.ArticulosBLL.GetList(x => true);

            Assert.IsNotNull(lista);
        }
    }
}