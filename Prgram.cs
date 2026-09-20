using System;

namespace TiendaEscolar
{
    internal class Program
    {
        static void Main()
        {
            string opcion;

            do
            {
                Console.WriteLine("\n=== TIENDA ESCOLAR ===");
                Console.WriteLine("1. Registrar producto");
                Console.WriteLine("2. Mostrar productos");
                Console.WriteLine("3. Calcular total de compra");
                Console.WriteLine("4. Salir");
                Console.Write("Selecciona una opcion: ");

                opcion = Console.ReadLine() ?? "4";

                switch (opcion)
                {
                    case "1":
                        Console.WriteLine("Registro de productos pendiente.");
                        break;

                    case "2":
                        Console.WriteLine("Listado de productos pendiente.");
                        break;

                    case "3":
                        Console.WriteLine("Calculo de compra pendiente.");
                        break;

                    case "4":
                        Console.WriteLine("Gracias por usar la tienda escolar.");
                        break;

                    default:
                        Console.WriteLine("Opcion invalida. Selecciona del 1 al 4.");
                        break;
                }
            }
            while (opcion != "4");
        }
    }
}
