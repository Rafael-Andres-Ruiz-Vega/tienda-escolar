using System;

namespace TiendaEscolar
{
    internal static class Ventas
    {
        public static void MostrarProductos()
        {
            if (Inventario.Productos.Count == 0)
            {
                Console.WriteLine("\nNo hay productos registrados.");
                return;
            }

            Console.WriteLine("\n=== PRODUCTOS REGISTRADOS ===");

            for (int i = 0; i < Inventario.Productos.Count; i++)
            {
                Producto producto = Inventario.Productos[i];

                Console.WriteLine(
                    $"{i + 1}. {producto.Nombre} - {producto.Precio:F2} pesos"
                );
            }
        }

        public static void CalcularCompra()
        {
            if (Inventario.Productos.Count == 0)
            {
                Console.WriteLine("\nPrimero debes registrar productos.");
                return;
            }

            decimal total = 0;

            while (true)
            {
                MostrarProductos();
                Console.Write("\nNumero del producto (0 para terminar): ");
                string entrada = Console.ReadLine();

                if (entrada == null)
                    return;

                if (!int.TryParse(entrada, out int numero))
                {
                    Console.WriteLine("Debes escribir un numero entero.");
                    continue;
                }

                if (numero == 0)
                    break;

                if (numero < 1 || numero > Inventario.Productos.Count)
                {
                    Console.WriteLine("Ese producto no existe.");
                    continue;
                }

                Console.Write("Cantidad de unidades: ");

                if (!int.TryParse(Console.ReadLine(), out int cantidad)
                    || cantidad <= 0)
                {
                    Console.WriteLine("La cantidad debe ser un entero mayor que cero.");
                    continue;
                }

                Producto producto = Inventario.Productos[numero - 1];

                try
                {
                    decimal subtotal = producto.Precio * cantidad;
                    decimal nuevoTotal = total + subtotal;
                    total = nuevoTotal;

                    Console.WriteLine(
                        $"Agregado: {cantidad} x {producto.Nombre} = {subtotal:F2} pesos"
                    );
                    Console.WriteLine($"Total acumulado: {total:F2} pesos");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Importe demasiado grande. No se agrego el producto.");
                }
            }

            Console.WriteLine($"\nTOTAL DE LA COMPRA: {total:F2} pesos");
        }
    }
}
