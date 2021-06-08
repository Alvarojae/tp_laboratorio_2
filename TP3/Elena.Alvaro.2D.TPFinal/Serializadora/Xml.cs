using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using Entidades;

namespace Serializadora
{

    public class Xml<T> : IArchivos<T>
    {
        /// <summary>
        /// Guarda el dato generico que es pasado como XMl
        /// </summary>
        /// <param name="ruta">Ruta adonde se guarda el archivo</param>
        /// <param name="datos">Dato generico que se va a guardar</param>
        /// <returns>true si pudo guardar, false si no pudo </returns>
        public bool Guardar(string ruta, T datos)
        {
            bool retorno = false;

            try
            {
                XmlSerializer nuevoXml = new XmlSerializer(typeof(T));
                using (XmlTextWriter newTW = new XmlTextWriter(ruta, Encoding.UTF8))
                {
                    nuevoXml.Serialize(newTW, datos);
                    retorno = true;
                }
            }
            catch (Exception e)
            {
                throw new MisExcepciones(string.Format("No se puedo leer el archivo"), e);
            }
            return retorno;
        }

        /// <summary>
        /// lee el dato generico que es pasado como XMl
        /// </summary>
        /// <param name="ruta">Ruta adonde se va a leer el archivo</param>
        /// <param name="datos">Dato generico que se va a leer</param>
        /// <returns>true si pudo guardar, false si no pudo </returns>
        public T Leer(string ruta)
        {
            try
            {
                XmlSerializer nuevoXml = new XmlSerializer(typeof(T));
                using (XmlTextReader newTR = new XmlTextReader(ruta))
                {
                    return (T)nuevoXml.Deserialize(newTR);  
                }
            }
            catch (Exception ex)
            {
                throw new MisExcepciones(string.Format("No se puedo leer el archivo"), ex);
            }
            
        }
    }
}
