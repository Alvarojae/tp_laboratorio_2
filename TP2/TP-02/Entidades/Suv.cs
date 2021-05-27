using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Suv : Vehiculo
    {

        /// <summary>
        /// Constructor de Suv
        /// </summary>
        /// <param name="marca">Marca del Suv</param>
        /// <param name="chasis">chasis del Suv</param>
        /// <param name="color">color del Suv</param>
        public Suv(EMarca marca, string chasis, ConsoleColor color)
            : base(chasis, marca, color)
        {
        }
        /// <summary>
        /// SUV son 'Grande'
        /// </summary>
        protected override ETamanio Tamanio
        {
            get
            {
                return Vehiculo.ETamanio.Grande;
            }
        }

        /// <summary>
        /// Muestra todos los datos del objeto del tipo Suv
        /// </summary>
        /// <returns>string con los datos del suv</returns>
        public override sealed string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("SUV");
            sb.AppendLine(base.Mostrar());
            sb.AppendLine("");
            sb.AppendLine("---------------------");

            return sb.ToString();
        }
    }
}
