using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using serializadora.Entidades;

namespace Serializador.Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Persona> personas = new List<Persona>();
            personas.Add(new Persona("Alvaro", "Elena", 23));
            personas.Add(new Persona("juan", "soliz", 23));
            personas.Add(new Persona("Roberto", "perez", 23));
            personas.Add(new Persona("Esteban", "Esteban", 23));
            personas.Add(new Persona("Gordo", "Bondiola", 23));


            //Persona persona1 = new Persona("Lautaro", "Lautaro", 23);
            //Persona persona2 = new Persona("Mauricio", "Cerizza", 30);

            Serializadora<Persona> serializadora = new Serializadora<Persona>();

            //List<Persona> personas = new List<Persona>();

            //personas.Add(persona);
            //personas.Add(persona1);
            //personas.Add(persona2);

            foreach (Persona item in personas)
            {
                if (serializadora.Guardar(item))
                {
                    Console.WriteLine("Archivo Guardado exitosamente");
                }
                else
                {
                    Console.WriteLine(serializadora.mensaje);
                }
            }
          


            Persona personasDeserializadas = serializadora.Leer();

            if (personasDeserializadas != null)
            {
                Console.WriteLine(personasDeserializadas.Mostrar());

                //foreach (Persona item in personasDeserializadas)
                //{
                //    Console.WriteLine(item.Mostrar());
                //}
            }
            else
            {
                Console.WriteLine(serializadora.mensaje);
            }


            Console.ReadKey();

        }
    }
}
