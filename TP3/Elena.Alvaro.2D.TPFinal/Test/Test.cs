using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Serializadora;
namespace Test
{
    class TestConsole
    {
        static void Main(string[] args)
        {
            // Nombre del alumno
            Console.Title = " TEST - Juan Alvaro Elena. 2°D";

            bool aux;
            Fabrica<Producto> alvaroFabrica = new Fabrica<Producto>("Alvaro");
            Alimento cindor30 = new Alimento(1, 15, 30, "Cindor", 500, 250, "Chocolate");
            Alimento cindor23 = new Alimento(1, 15, 23, "Cindor", 500, 250, "Chocolate");
            Materiales leche25 = new Materiales("Leche", 25, true);

            //se intente de validar la creacion del producto y hay mas productos que materiales
            Console.WriteLine("Se intenta de crear 30 paquetes de cindor - Con solamente 25 de leche");
            if (leche25.ConsumirMateriales(cindor30))
            {
                aux = alvaroFabrica + cindor30;
                Console.WriteLine("Se crearon correctamente");
            }
            else
                Console.WriteLine("No hay suficiente materiales");

            Console.WriteLine("Enter para continuar");
            Console.ReadLine();

            //se intente de validar la creacion del producto y se disminuye los materiales de leche y se agrega a la lista de la fabrica
            Console.WriteLine("Se intenta de crear 23 paquetes de cindor - Con 25 de leche");
            if (leche25.ConsumirMateriales(cindor23))
            {
                Console.WriteLine("Se crearon correctamente");
                aux=alvaroFabrica + cindor23;
            }  
            else
                Console.WriteLine("No hay suficiente materiales");

            Console.WriteLine(leche25.Informacion());

            Console.WriteLine("Enter para continuar");
            Console.ReadLine();

            //Guardar infome de materiales 
            Console.WriteLine("Se guardan los materiales serializandolos");
            Serializadora<Materiales> serializadora = new Serializadora<Materiales>();
            if(serializadora.Guardar("Leche", leche25))
                Console.WriteLine("exito al guardar");

            //Guardar infome de productos
            Console.WriteLine("Se guardan los materiales ");
            Texto.EscribirTexto(cindor23.Informacion());

            Console.ReadLine();
        }
    }
}
