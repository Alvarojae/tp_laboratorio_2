using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Herramienta : Producto
    {
        protected string material;
        protected string marca;

        public Herramienta(int id, float valor, int stock, string nombre, int peso, string material, string marca)
            :base(id, valor, stock, nombre, peso)
        {
            this.material = material;
            this.marca = marca;
        }

        public override string Informacion()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.Informacion());
            sb.AppendLine($"Material: {this.material}");
            sb.AppendLine($"Marca: {this.marca}");

            return sb.ToString();
        }
    }
}

