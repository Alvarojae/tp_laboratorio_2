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
        /// <summary>
        /// Guarda la informacion pasada al metodo en un archivo llamado "Productos.txt"
        /// </summary>
        /// <param name="texto">texto a guardar en el archivo</param>
        public static void EscribirTexto(string texto)
        {
            StreamWriter file = new StreamWriter("Productos.txt");
            file.Write(texto);
            file.Close();
        }

        /// <summary>
        /// Guarda haciendo append la infomarcion pasada en un archivo llamado "Excepciones.txt"
        /// </summary>
        /// <param name="texto">texto a guardar en el archivo</param>
        public static void EscribirExcepciones(string texto)
        {
            StreamWriter file = new StreamWriter("Excepciones.txt", append: true);
            file.WriteLine(texto);
            file.Close();
        }
        

    }
}
