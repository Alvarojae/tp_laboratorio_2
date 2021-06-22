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
            Serializadora<Materiales> serializadora = new Serializadora<Materiales>();
            
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
            //Muestra el material para mostrar cuanto es el restante
            Console.WriteLine(leche25.Informacion()+ " Restante");

            Console.WriteLine("Enter para continuar");
            Console.ReadLine();

            //Guardar infome de materiales  serializado
            Console.WriteLine("Se intentan guardar los materiales serializandolos");
            if(serializadora.Guardar("Leche", leche25))
                Console.WriteLine("exito al guardar la serializacion en un .xml");

            Console.WriteLine("Enter para continuar");
            Console.ReadLine();

            //Guardar infome de productos como string
            Console.WriteLine("Se guardan los materiales en forma de string en un .txt");
            Texto.EscribirTexto(cindor23.Informacion());
            Console.WriteLine("Enter para salir");


            Console.WriteLine("Enter para continuar");
            Console.ReadLine();

            Console.WriteLine("Se cargan los materiales por Sql");

            Conexion conexion = new Conexion();
            List<Materiales> materialesSql = conexion.LeerMaterial();

            foreach (Materiales item in materialesSql)
            {
                Console.WriteLine(item.Informacion());
            }

            Console.WriteLine("Enter para continuar");
            Console.ReadLine();
            Console.WriteLine("Cambio los materiales a 15 y los guardo en el sql y los vuelvo a leer");
            foreach (Materiales item in materialesSql)
            {
                item.Cantidad = 15;
            }

            conexion.GuardarMaterial(materialesSql);

            materialesSql = conexion.LeerMaterial();

            foreach (Materiales item in materialesSql)
            {
                Console.WriteLine(item.Informacion());
            }
            Console.ReadLine();
        }
    }
}
