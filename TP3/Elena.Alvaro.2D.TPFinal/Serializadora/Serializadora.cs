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
        public string mensaje;

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
            catch (Exception e)
            {
                Texto.EscribirExcepciones(e.ToString());
                this.mensaje = e.Message;
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
            catch (Exception e)
            {
                Texto.EscribirExcepciones(e.ToString());
                this.mensaje = e.Message;
            }
            return t;
        }

        bool IArchivos<T>.Leer(string archivo, out T datos)
        {
            throw new NotImplementedException();
        }
    }
}
