using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Biografia : Publicacion
    {
        /// <summary>
        /// contructor de la  Biografia
        /// </summary>
        /// <param name="nombre">nombre de la  Biografia</param>
        public Biografia(string nombre) : base(nombre)
        {
        }
        /// <summary>
        /// contructor de la  Biografia
        /// </summary>
        /// <param name="nombre">nombre de la  Biografia</param>
        /// <param name="stock">stock de la  Biografia</param>
        public Biografia(string nombre, int stock) : base(nombre, stock)
        {
        }

        /// <summary>
        /// contructor de la  Biografia 
        /// </summary>
        /// <param name="nombre">nombre de la  Biografia</param>
        /// <param name="stock">stock de la  Biografia</param>
        /// <param name="importe">valor de la  Biografia</param>
        public Biografia(string nombre, int stock, float importe) : base(nombre, stock, importe)
        {
        }

        /// <summary>
        /// crea una biografia apartir de un string
        /// </summary>
        /// <param name="nombre">string con el nombre del objeto a crear </param>
        /// 
        public static explicit operator Biografia(string nombre)
        {
            return new Biografia(nombre);
        }


        /// <summary>
        /// getter que devuelve true si contiene color o no false
        /// </summary>
        protected override bool EsColor
        {
            get
            {
                return false;
            }
        }

        /// <summary>
        /// getter que devuelve true si hay stock, false en lo contrario 
        /// </summary>
        public override bool HayEstock
        {
            get
            {
                if (this.stock > 0)
                    return true;
                else
                    return false;
            }
        }
    }
}
