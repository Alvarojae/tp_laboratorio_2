using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Fabrica<T> where T : Producto
    {
        public string nombre;
        public List<T> Listaproductos;

        public Fabrica()
        {
            this.Listaproductos = new List<T>();
        }

        public Fabrica(string nombre):this()
        {
            this.nombre = nombre;
        }

        /// <summary>
        /// Ingresa un item generico es una lista generica del mismo tipo
        /// </summary>
        /// <param name="lista">Una lista generica de fabrica</param>
        /// <param name="item"> un item generico</param>
        /// <returns>true</returns>
        public static bool operator +(Fabrica<T> lista, T item) 
        {
            try
            {
                if(lista !=null && item !=null)
                    lista.Listaproductos.Add(item);
                return true;
            }catch(Exception)
            {
                return false;
            }
            
        }
    }
}
