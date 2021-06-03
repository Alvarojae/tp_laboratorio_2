using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace serializadora.Entidades
{
    public class Serializadora<T>
    {
        public string mensaje;
        public bool Guardar(T t)
        {
            bool retorno = false;

            try
            {
                Xml<T> guardarPersona = new Xml<T>();

                retorno = guardarPersona.Guardar(AppDomain.CurrentDomain.BaseDirectory + @"personas.xml", t);
                
            }
            catch (MisExcepciones e)
            {
                this.mensaje = e.Message;
            }

            return retorno;
        }

        public T Leer()
        {
            T t = default(T);
            try
            {
                Xml<T> leerPersona = new Xml<T>();

                if (leerPersona.Leer(AppDomain.CurrentDomain.BaseDirectory + @"personas.xml", out T auxt))
                {
                    t = auxt;
                }

            }
            catch (MisExcepciones e)
            {

                this.mensaje = e.Message;
            }

            return t;

        }
    }
}
