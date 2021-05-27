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
        public static List<Producto> productos;

        static Fabrica()
        {
            productos = new List<Producto>();
        }

        public Fabrica(string nombre)
        {
            this.nombre = nombre;
        }

        public static bool operator +(Fabrica<T> fabrica, T item)
        {
            Fabrica<T>.productos.Add((Producto)item);
            return true;
        }
    }
}
