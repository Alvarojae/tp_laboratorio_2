using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Materiales
    {
        private string nombre;
        private int cantidad;
        private bool alimento;

        public Materiales(string nombre, int cantidad, bool alimento)
        {
            this.nombre = nombre;
            this.cantidad = cantidad;
            this.alimento = alimento;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("{0} - {1}",this.nombre,this.cantidad);
            return sb.ToString();
        }

        public override string ToString()
        {
            return this.Mostrar();
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
