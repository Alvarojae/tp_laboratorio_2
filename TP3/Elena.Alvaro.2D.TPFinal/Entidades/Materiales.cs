using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Materiales : IInformacion
    {
        private string nombre;
        private int cantidad;
        private bool alimento;

        /// <summary>
        /// constructor de materiales
        /// </summary>
        /// <param name="nombre">nombre del materiales</param>
        /// <param name="cantidad">cantidad del materiales</param>
        /// <param name="alimento">si es alimento o no</param>
        
        public Materiales(string nombre, int cantidad, bool alimento)
        {
            this.nombre = nombre;
            this.cantidad = cantidad;
            this.alimento = alimento;
        }

        public Materiales()
        {
        }

        public int Cantidad
        {
            get { return this.cantidad; }
            set {this.cantidad = value; }
        }

        public bool Material
        {
            get {return this.alimento;}
            set { this.alimento = value; }
        }

        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }
        /// <summary>
        /// Consigue toda la informacion de la clase Materiales y la convierte en string
        /// </summary>
        /// <returns>string con toda la informacion</returns>
        public string Informacion()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("{0} - {1}",this.nombre,this.cantidad);
            return sb.ToString();
        }

        public override string ToString()
        {
            return this.Informacion();
        }

   
        /// <summary>
        /// Comprueba que es capas de crear un producto segun la cantidad de productos y su material
        /// </summary>
        /// <param name="producto">un producto</param>
        /// <returns>true si se pudo consumir. false si no se pudo consumir</returns>
        public bool ConsumirMateriales(Producto producto)
        {
            if((this.alimento==true && producto is Alimento) || (this.alimento == false && producto is Herramienta))
            {
                if (this.Cantidad >= producto.Cantidad)
                {
                    this.Cantidad = this.Cantidad - producto.Cantidad;
                    return true;
                }   
            }
            return false;
        }

        /// <summary>
        /// Recarga los materiales en 10 unidades
        /// </summary>
        public void AgregarMateriales()
        {
            this.Cantidad += 10;
        }


        public bool SonIguales(Materiales obj)
        {
            if (this.Nombre == obj.Nombre && this.Material == obj.Material && this.Cantidad == obj.Cantidad)
                return true;

            return false;
        }

    }
}
