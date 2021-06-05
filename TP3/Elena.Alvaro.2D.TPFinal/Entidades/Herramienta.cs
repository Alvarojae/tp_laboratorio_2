using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Herramienta : Producto , IClass
    {
        protected string material;
        protected string marca;

        public Herramienta(int id, int valor, int stock, string nombre, int peso, string material, string marca)
            :base(id, valor, stock, nombre, peso)
        {
            this.material = material;
            this.marca = marca;
        }

        /// <summary>
        /// Consigue toda la informacion de la clase Herramienta y la convierte en string
        /// </summary>
        /// <returns>string con toda la informacion</returns>
        public override string Informacion()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("\nHerramienta");
            sb.Append(base.Informacion());
            sb.AppendLine($"Material: {this.material}");
            sb.AppendLine($"Marca: {this.marca}");

            return sb.ToString();
        }
    }
}

