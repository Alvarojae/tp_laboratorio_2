using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Publicacion
    {
        protected float importe;
        protected string nombre;
        protected int stock;
  
        /// <summary>
        /// contructor de publicacion 
        /// </summary>
        /// <param name="nombre">nombre del libro</param>
        public Publicacion(string nombre)
        {
            this.nombre = nombre;
        }
        /// <summary>
        /// contructor de publicacion 
        /// </summary>
        /// <param name="nombre">nombre del libro</param>
        /// <param name="stock">stock del libro</param>
        public Publicacion(string nombre, int stock) : this(nombre)
        {
            this.Stock = stock;
        }

        /// <summary>
        /// contructor de publicacion 
        /// </summary>
        /// <param name="nombre">nombre del libro</param>
        /// <param name="stock">stock del libro</param>
        /// <param name="importe">valor del libro</param>
        public Publicacion(string nombre, int stock, float importe):this(nombre, stock)
        {
            this.importe = importe;
        }

        /// <summary>
        /// setter y getter de Stock, valida que no sea negativo cuando le ingresamos un valor
        /// </summary>
        public int Stock 
        {
            get
            {
                return this.stock;
            }
            set
            {
                if (value >= 0)
                    this.stock = value;
            }
        }

        /// <summary>
        /// muestra toda la informacion de la publicacion
        /// </summary>
        /// <returns>devuelve al informacion en forma de string</returns>
        public string Informacion()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre: {this.nombre}");
            sb.AppendFormat("Stock: {0}\n", this.Stock);
            if (EsColor==true)
                sb.Append($"Color: SI\n");
            else
                sb.Append($"Color: NO\n");

            sb.AppendLine($"Valor: {this.Importe}");

            return sb.ToString();
        }

        /// <summary>
        /// sobrescribir el string para devolver la infomracion
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.nombre;
        }

        /// <summary>
        /// getter que devuelve tiene color o no
        /// </summary>
        protected abstract bool EsColor
        {
            get;
        }

        /// <summary>
        /// getter que devuelve si hay stock 
        /// </summary>
        public virtual bool HayEstock
        {
            get
            {
                if (this.stock > 0 && this.importe > 0)
                    return true;
                else
                    return false;
            }
        }


        /// <summary>
        /// get que devuelve el importe
        /// </summary>
        public float Importe
        {
            get
            {
                return this.importe;
            }
        }
    }
}
