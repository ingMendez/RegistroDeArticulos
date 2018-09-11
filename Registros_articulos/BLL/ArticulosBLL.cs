using Registros_articulos.DAL;
using Registros_articulos.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Text;
using System.Linq.Expressions;

namespace Registros_articulos.BLL

    ////
    ///aqui van todas las operaciones a realizar
    ///
{
     public class ArticulosBLL
    {
        /// <summary>
        ///  aqui vamos aguardar en la entidad de la base de datos
        /// </summary>
        /// <param name="articulos"></param>
        /// <returns></returns>
        public static bool Guardar(Articulos articulos)
        {
            bool paso = false;
            // nuestra variable que nos dara acceso a la base de dato
            Contexto contexto = new Contexto();

            try
            {
                if (contexto.articulos.Add(articulos) != null)
                {
                    contexto.SaveChanges();
                    paso = true;
                }
                contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }
        /// <summary>
        /// en esta clase  se modifican los articulos ya creado
        /// </summary>
        /// <param name="articulos"></param>
        /// <returns></returns>
       public static bool Modificar(Articulos articulos)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                contexto.Entry(articulos).State = System.Data.Entity.EntityState.Modified;
                if (contexto.SaveChanges() > 0)
                {
                    paso = true;
                }
                contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return paso;

        }

        public static bool Eliminar(int id)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                Articulos articulo = contexto.articulos.Find(id);
                contexto.articulos.Remove(articulo);

                if (contexto.SaveChanges() > 0)
                {
                    paso = true;
                }
                contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }
        public static Articulos Buscar(int id)
        {
            Contexto contexto = new Contexto();
            Articulos articulo = new Articulos();
            try
            {
                articulo = contexto.articulos.Find(id);
                contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return articulo;
        }

        public static List<Articulos> GetList(Expression<Func<Articulos,bool>>expression)
        {
            List<Articulos> articulos = new List<Articulos>();
            Contexto contexto = new Contexto();

            try
            {
                articulos = contexto.articulos.Where(expression).ToList();
                contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return articulos;
        }
    }
}
