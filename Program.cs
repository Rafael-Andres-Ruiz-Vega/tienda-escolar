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
                     Inventario.RegistrarProducto();
                     break; 

                    case "2": 
                        Ventas.MostrarProductos();
                        break;

                    case "3":
                        Ventas.CalcularCompra();
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
