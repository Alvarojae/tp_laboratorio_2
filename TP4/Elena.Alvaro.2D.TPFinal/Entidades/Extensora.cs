using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entidades
{
    public static class Extensora
    {
        /// <summary>
        /// Se pasa un string y devueve un cuadro de si o no || METODOS DE EXTENSION
        /// </summary>
        /// <param name="cadena">string que quiere mostrar como Mensaje en la confirmacion</param>
        /// <returns></returns>
        public static DialogResult YesOrNo(this string cadena)
        {
            return MessageBox.Show(cadena, "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }
    }
}
