using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Comic : Publicacion
    {
        private bool esColor;

        /// <summary>
        /// Constructor del comic
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="esColor"></param>
        /// <param name="stock"></param>
        /// <param name="importe"></param>
        public Comic(string nombre, bool esColor, int stock, float importe): base(nombre, stock, importe)
        {
            this.esColor = esColor;
        }

        /// <summary>
        /// getter que devuelve si contiene color o no 
        /// </summary>
        protected override bool EsColor
    {
        get
        {
            return this.esColor;
        }
    }
    }
}
