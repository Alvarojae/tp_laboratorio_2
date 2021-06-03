using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
namespace serializadora.Entidades
{
    public class Xml<T> 
    {
        public bool Guardar(string ruta, List<T> datos)
        {
            bool retorno = false;

            try
            {
                XmlSerializer nuevoXml = new XmlSerializer(typeof(T));
              
                using (FileStream newTW = new FileStream(ruta, FileMode.OpenOrCreate))
                {
                    nuevoXml.Serialize(newTW, datos);
                    retorno = true;
                }
            }
            catch (Exception e)
            {
                throw new MisExcepciones(e);
            }
            return retorno;

        }

        public bool Leer(string ruta, out T datos)
        {
            bool retorno = false;
            try
            {
                XmlSerializer nuevoXml = new XmlSerializer(typeof(T));

                using (XmlTextReader newTR = new XmlTextReader(ruta))
                {
                    datos = (T)nuevoXml.Deserialize(newTR);
                    retorno = true;
                }
            }
            catch (Exception e)
            {

                throw new MisExcepciones(e);
            }

            return retorno;
        }
    }
}
