using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Producto : IClass
    {
        protected int id;
        protected int stock;
        protected int peso;
        protected int valor;
        protected string nombre;

        /// <summary>
        /// Constructor de Producto
        /// </summary>
        /// <param name="id">id del Producto</param>
        /// <param name="valor">valor del Producto</param>
        /// <param name="stock">stock del Producto</param>
        /// <param name="nombre">nombre del Producto</param>
        /// <param name="peso">peso del Producto</param>
        public Producto(int id, int valor,int stock ,string nombre, int peso)
        {
            this.id = id;
            this.valor = valor;
            this.stock = stock;
            this.nombre = nombre;
            this.peso = peso;
        }

        /// <summary>
        /// Consigue toda la informacion de la clase Producto y la convierte en string
        /// </summary>
        /// <returns>string con toda la informacion</returns>
        public virtual string Informacion()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre: {this.nombre}");
            sb.AppendLine($"Id: {this.id}");
            sb.AppendFormat("Stock: {0} - Valor:$ {1}\n", this.stock, this.valor);
            sb.AppendLine($"Peso: {this.peso} grm");

            return sb.ToString();
        }

        public override string ToString()
        {
            return this.nombre;
        }
    }
}
