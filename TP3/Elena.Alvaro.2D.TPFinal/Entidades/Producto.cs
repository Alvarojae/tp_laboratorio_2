using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Producto
    {
        protected int id;
        protected int stock;
        protected float peso;
        protected float valor;
        protected string nombre;
        

        public Producto(int id,float valor,int stock ,string nombre, float peso)
        {
            this.id = id;
            this.valor = valor;
            this.stock = stock;
            this.nombre = nombre;
            this.peso = peso;
        }

        public virtual string Informacion()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre: {this.nombre}");
            sb.AppendLine($"Id: {this.id}");
            sb.AppendFormat("Stock: {0} - Valor: {1}\n", this.stock, this.valor);
            sb.AppendLine($"Peso: {this.peso}");

            return sb.ToString();
        }

        public override string ToString()
        {
            return this.nombre;
        }
    }
}
