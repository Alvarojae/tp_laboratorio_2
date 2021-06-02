using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Materiales : IClass
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

        public int Cantidad 
        {
            get
            {
                return this.cantidad;
            }
             set
            {
                this.cantidad = value;
            }
        }

        public bool Material
        {
            get
            {
                return this.alimento;
            }
        }

        public bool ConsumirMateriales(int cantidad)
        {
            if(this.Cantidad>= cantidad)
            {
                this.Cantidad = this.Cantidad - cantidad;
                return true;
            }
            return false;
        }

    
    }
}
