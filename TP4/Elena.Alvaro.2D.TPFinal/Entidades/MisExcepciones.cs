using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Entidades
{
    public class MisExcepciones : Exception
    {
        public MisExcepciones(Exception innerexception) : this(innerexception.Message, innerexception)
        {
            
        }

        /// <summary>
        /// Constructor para crear una excepcion custom, guarda en un txt el mensaje
        /// </summary>
        /// <param name="message">mensaje a guardar en la excepcion</param>
        /// <param name="inner">la excepcion</param>
        public MisExcepciones(string message, Exception inner) : base(message, inner) 
        {
            EscribirExcepciones(message);
        }

        /// <summary>
        /// Guarda haciendo append la infomarcion pasada en un archivo llamado "Excepciones.txt"
        /// </summary>
        /// <param name="texto">texto a guardar en el archivo</param>
        public static void EscribirExcepciones(string texto)
        {
            StreamWriter file = null;
            DateTime thisDay = DateTime.Today;
            try
            {
                file = new StreamWriter("Excepciones.txt", append: true);
                file.WriteLine(texto + " - " + thisDay.ToString("d"));
            }
            catch (Exception){ }
            finally
            {
                if (file != null)
                    file.Close();
            }
        }
    }
}
