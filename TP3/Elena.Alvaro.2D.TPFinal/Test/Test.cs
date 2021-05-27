using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
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
            bool aux;
            aux = alvaroFabrica + new Comida(1, 15, 2, "Cindor", 500, 250, "Chocolate", "vaca batida");
            aux = alvaroFabrica + new Herramienta(2, 1050, 5, "Pinza multiuso", 560, "Metal", "Black & Decker");

            foreach (Producto item in Fabrica<Producto>.productos)
            {
                Console.WriteLine(item.Informacion());
            }
            Console.ReadLine();
        }
    }
}
