using Registros_articulos.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
            

            return false;
        }
    }
}
