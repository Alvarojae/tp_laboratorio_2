using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Serializadora
{
    public class Serializadora<T> : IArchivos<T>
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
            catch (Exception guardar)
            {
                throw new MisExcepciones("No se puedo guardar el archivo", guardar);
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
                t = leerT.Leer(AppDomain.CurrentDomain.BaseDirectory + ("Material - " + ruta + ".xml"));   
            }
            catch (Exception ProblemaAlLeer)
            {
                throw new MisExcepciones(string.Format("No se puedo leer el archivo"), ProblemaAlLeer);
            }
            return t;
        }
    }
}
