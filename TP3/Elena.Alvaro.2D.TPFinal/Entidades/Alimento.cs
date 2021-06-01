using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Alimento : Producto
    {
        protected int calorias;
        protected string sabor;
        protected string ingredientes;

        public Alimento(int id, int valor, int stock, string nombre, int peso, int calorias, string sabor, string ingredientes) 
            :base( id,  valor,  stock,  nombre,  peso)
        {
            this.calorias = calorias;
            this.sabor = sabor;
            this.ingredientes = ingredientes;
        }

        public override string Informacion()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.Informacion());
            sb.AppendLine($"Calorias: {this.calorias}");
            sb.AppendLine($"Sabor: {this.sabor}");
            sb.AppendLine($"Ingredientes: {this.ingredientes}");

            return sb.ToString();
        }


    }
}
