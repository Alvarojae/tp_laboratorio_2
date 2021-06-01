using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// La clase Vehiculo no deberá permitir que se instancien elementos de este tipo.
    /// </summary>
    public abstract class Vehiculo
    {
        private EMarca marca;
        private string chasis;
        private  ConsoleColor color;

        /// <summary>
        /// Constructor de Vehiculo
        /// </summary>
        /// <param name="marca">Marca del Ciclomotor</param>
        /// <param name="chasis">chasis del Ciclomotor</param>
        /// <param name="color">color del Ciclomotor</param>
        public Vehiculo(string chasis, EMarca marca, ConsoleColor color)
        {
            this.marca = marca;
            this.chasis = chasis;
            this.color = color;
        }

        /// <summary>
        /// ReadOnly: Retornará el tamaño
        /// </summary>
        protected abstract ETamanio Tamanio 
        { 
            get;
        }

        /// <summary>
        /// Publica todos los datos del Vehiculo.
        /// </summary>
        /// <returns></returns>
    
        public virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("CHASIS: {0}\r\n", this.chasis);
            sb.AppendFormat("MARCA : {0}\r\n", this.marca.ToString());
            sb.AppendFormat("COLOR : {0}\r\n", this.color.ToString());
            sb.AppendLine("---------------------");
            sb.AppendFormat("TAMAÑIO : {0}\r", this.Tamanio.ToString());

            return sb.ToString();
        }
        /// <summary>
        /// Muestra la informacion casteando 
        /// </summary>
        /// <param name="p">vehiculo a mostrar</param>
        public static explicit operator string(Vehiculo p)
        {
            return p.Mostrar();
        }

        /// <summary>
        /// Dos vehiculos son iguales si comparten el mismo chasis
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <returns></returns>
        public static bool operator ==(Vehiculo v1, Vehiculo v2)
        {
            return (v1.chasis == v2.chasis);
        }
        /// <summary>
        /// Dos vehiculos son distintos si su chasis es distinto
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <returns></returns>
        public static bool operator !=(Vehiculo v1, Vehiculo v2)
        {
            return !(v1 == v2);
        }


        /// <summary>
        /// Enumerado de los diferentes marca de autos (Chevrolet, Ford, Renault, Toyota, BMW, Honda, HarleyDavidson)
        /// </summary>
        public enum EMarca
        {
            Chevrolet, Ford, Renault, Toyota, BMW, Honda, HarleyDavidson
        }

        /// <summary>
        /// Enumerado de los diferentes tamaños de vehiculos (Chico, Mediano, Grande)
        /// </summary>
        public enum ETamanio
        {
            Chico, Mediano, Grande
        }
    }
}
