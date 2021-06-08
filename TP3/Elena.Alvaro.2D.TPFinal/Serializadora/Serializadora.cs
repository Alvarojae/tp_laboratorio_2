using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Serializadora
{
    public class Serializadora<T> : IArchivosGuardar<T>
    {

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ruta"></param>
        /// <param name="t"></param>
        /// <returns></returns>
        public bool Guardar(string ruta, T t)
        {
            bool retorno = false;
            try
            {
                Xml<T> guardarT = new Xml<T>();
                retorno = guardarT.Guardar(AppDomain.CurrentDomain.BaseDirectory +("Material - " + ruta + ".xml"), t);
            }
            catch (Exception exa)
            {
                throw new MisExcepciones(string.Format("No se puedo guardar el archivo"), exa);
            }

            return retorno;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ruta"></param>
        /// <returns></returns>
        public T Leer(string ruta)
        {
            T t = default(T);
            try
            {
                Xml<T> leerT = new Xml<T>();
                if (leerT.Leer(AppDomain.CurrentDomain.BaseDirectory + ("Material - " + ruta + ".xml"), out T auxT))
                {
                    t = auxT;
                }
            }
            catch (Exception ex)
            {
                throw new MisExcepciones(string.Format("No se puedo leer el archivo"), ex);
            }
            return t;
        }
    }
}
