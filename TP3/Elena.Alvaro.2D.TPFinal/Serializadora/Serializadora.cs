using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Serializadora
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

                retorno = guardarPersona.Guardar(AppDomain.CurrentDomain.BaseDirectory + @"leche.xml", t);

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

                if (leerPersona.Leer(AppDomain.CurrentDomain.BaseDirectory + @"personas.xml", out T auxT))
                {
                    t = auxT;
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
