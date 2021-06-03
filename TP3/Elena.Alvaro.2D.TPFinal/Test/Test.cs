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
            // Configuración de la pantalla
            Console.SetWindowPosition(0, 0);

            // Nombre del alumno
            Console.Title = " TEST - Juan Alvaro Elena. 2°D";

            //List<Producto> productos = new List<Producto>();
            //productos.Add((Producto)new Comida(1, 15, 2, "Cindor", 500, 250, "Chocolate", "vaca batida"));
            //productos.Add((Producto)new Herramienta(2, 1050, 5, "Pinza multiuso", 560, "Metal", "Black & Decker"));

            Fabrica<Producto> alvaroFabrica = new Fabrica<Producto>("Alvaro");
            List<Materiales> listaMateriales = new List<Materiales>();
            bool aux;
            aux = alvaroFabrica + new Alimento(1, 15, 2, "Cindor", 500, 250, "Chocolate");
            aux = alvaroFabrica + new Herramienta(2, 1050, 5, "Pinza multiuso", 560, "Metal", "Black & Decker");

            Materiales leche = new Materiales("Leche", 25, true);
            Materiales hierro = new Materiales("Hierro", 35, false);
            
            foreach (Producto item in alvaroFabrica.Listaproductos)
            {
                Console.WriteLine(item.Informacion());

            }

            foreach (Materiales item in listaMateriales)
            {
                Console.WriteLine(item.Informacion());

            }

            Console.WriteLine("Se intenta de crear 30 paquetes de cindor - Con solamente 25 de leche");
            if (leche.ConsumirMateriales(30))
                Console.WriteLine("Se crearon correctamente");
            else
                Console.WriteLine("No hay suficiente materiales");

            Console.WriteLine("Enter para continuar");
            Console.ReadLine();

            Console.WriteLine("Se intenta de crear 23 paquetes de cindor - Con solamente 25 de leche");
            if (leche.ConsumirMateriales(23))
                Console.WriteLine("Se crearon correctamente");
            else
                Console.WriteLine("No hay suficiente materiales");

            Console.WriteLine(leche.Informacion());

            Serializadora<Materiales> material = new Serializadora<Materiales>();
            if (material.Guardar(leche))
                Console.WriteLine("Se guardo con exito");
            else
                Console.WriteLine("Hubo un problema con el guardado");

            Console.ReadLine();
        }
    }
}
