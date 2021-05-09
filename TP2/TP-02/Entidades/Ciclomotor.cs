using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Ciclomotor : Vehiculo
    {
        /// <summary>
        /// Constructor de Ciclomotor
        /// </summary>
        /// <param name="marca">Marca del Ciclomotor</param>
        /// <param name="chasis">chasis del Ciclomotor</param>
        /// <param name="color">color del Ciclomotor</param>
        public Ciclomotor(EMarca marca, string chasis, ConsoleColor color) :base(chasis, marca, color)
        {
        }

        /// <summary>
        /// Ciclomotor son 'Chico'
        /// </summary>
        protected override ETamanio Tamanio
        {
            get
            {
                return Vehiculo.ETamanio.Chico;
            }
        }

        /// <summary>
        /// Muestra todos los datos del objeto del tipo ciclomotor
        /// </summary>
        /// <returns>string con los datos del ciclomotor</returns>
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("CICLOMOTOR");
            sb.AppendLine(base.Mostrar());
            sb.AppendFormat("TAMAÑO : {0}", this.Tamanio);
            sb.AppendLine("");
            sb.AppendLine("---------------------");

            return sb.ToString();
        }
    }
}
