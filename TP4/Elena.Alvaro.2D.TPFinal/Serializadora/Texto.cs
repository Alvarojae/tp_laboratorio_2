using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Entidades;

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

            StreamWriter file = null;
            try
            {
                file = new StreamWriter("Productos.txt", append: true);
                file.Write(texto);
            }
            catch(Exception ex)
            {
                throw new MisExcepciones(string.Format("No se puedo escribir los Productos"), ex);
            }
            finally
            {
                if (file != null)
                    file.Close();
            }
        }
    }
}
