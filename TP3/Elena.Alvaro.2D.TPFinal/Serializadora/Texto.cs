using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Serializadora
{
    public class Texto
    {
        public static void EscribirTexto(string texto)
        {
            StreamWriter file = new StreamWriter("Productos.txt");
            file.Write(texto);
            file.Close();
            
        }

    }
}
