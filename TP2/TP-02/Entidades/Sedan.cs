using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;

namespace Entidades
{
    public class Sedan : Vehiculo
    {
       
        private ETipo tipo;


        /// <summary>
        /// Constructor de Sedan
        /// </summary>
        /// <param name="marca">Marca del Sedan</param>
        /// <param name="chasis">chasis del Sedan</param>
        /// <param name="color">color del Sedan</param>
        /// <param name="tipo">Cantidad de puertas</param>
        public Sedan(EMarca marca, string chasis, ConsoleColor color, ETipo tipo) : base(chasis, marca, color)
        {
            this.tipo = tipo;
        }

        /// <summary>
        /// Por defecto, TIPO será CuatroPuertas
        /// </summary>
        /// <param name="marca"></param>
        /// <param name="chasis"></param>
        /// <param name="color"></param>
        public Sedan(EMarca marca, string chasis, ConsoleColor color) : this(marca, chasis, color, ETipo.CuatroPuertas)
        {
        }



        /// <summary>
        /// Sedan son 'Mediano'
        /// </summary>
        protected override ETamanio Tamanio
        {
            get
            {
                return Vehiculo.ETamanio.Mediano;
            }
        }

        /// <summary>
        /// Muestra todos los datos del objeto del tipo sedan
        /// </summary>
        /// <returns>string con los datos del sedan</returns>
        public override sealed string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("SEDAN");
            sb.AppendLine(base.Mostrar());
            sb.Append("TIPO : " + this.tipo);
            sb.AppendLine("");
            sb.AppendLine("---------------------");

            return sb.ToString();
        }

        /// <summary>
        /// Enumerado de los diferentes tipos de puertas (CuatroPuertas, CincoPuertas)
        /// </summary>
        public enum ETipo { CuatroPuertas, CincoPuertas }
    }
}
