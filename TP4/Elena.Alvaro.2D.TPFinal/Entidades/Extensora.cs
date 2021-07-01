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
        public static DialogResult YesOrNo(this string cadena)
        {
            return MessageBox.Show(cadena, "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }
    }
}
