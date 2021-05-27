using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Vendedor
    {
        private string nombre;
        private List<Publicacion> listVentas;

        /// <summary>
        /// Inicia la lista de ventas
        /// </summary>
        private Vendedor()
        {
            this.listVentas = new List<Publicacion>();
        }

        /// <summary>
        /// Crea el usuario de Ventas y llama al contructor para crear la lista
        /// </summary>
        /// <param name="nombre">nombre del usuario</param>
        public Vendedor(string nombre):this()
        {
            this.nombre = nombre;
        }
        /// <summary>
        /// devuelve la informacion del vendedor
        /// </summary>
        /// <param name="V"></param>
        /// <returns>retorna toda la informacion del vendedor en forma de string</returns>
        public static string InformeDeVentas(Vendedor V)
        {
            float aux = 0;
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Nombre: {0}",V.nombre);
            foreach (Publicacion item in V.listVentas)
            {
                sb.Append("----------------------------\n");
                sb.AppendLine($"PUPLICACION:{item.Informacion()}");
                aux = aux + item.Importe;
            }
            sb.AppendLine("----------------------------");
            sb.AppendLine($"Ganancia Total :{aux}");

            return sb.ToString();
        }

        /// <summary>
        /// agrega un publicacion al vendedor si hay stock 
        /// </summary>
        /// <param name="v">vendedor </param>
        /// <param name="p">publicaicon del libro</param>
        /// <returns>agrega un libro si hay stock si no devuelve false</returns>
        public static bool operator +(Vendedor v, Publicacion p)
        {
            if (p.HayEstock == true)
            {
                v.listVentas.Add(p);
                p.Stock--;
                return true;
            }
            return false;
        }

    }
}
