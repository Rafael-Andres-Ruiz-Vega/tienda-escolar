using System;
using System.Collections.Generic;
using System.Globalization;

namespace TiendaEscolar
{
    internal class Producto
    {
        public string Nombre { get; set; } = "";
        public decimal Precio { get; set; }
    }

    internal static class Inventario
    {
        public static List<Producto> Productos = new List<Producto>();

        public static void RegistrarProducto()
        {
            Console.Write("\nNombre del producto: ");
            string nombre = (Console.ReadLine() ?? "").Trim();

            if (nombre == "")
            {
                Console.WriteLine("El nombre no puede estar vacio.");
                return;
            }

            Console.Write("Precio en pesos, sin separadores de miles: ");
            string entrada = (Console.ReadLine() ?? "").Trim();
            entrada = entrada.Replace(',', '.');

            bool precioValido = decimal.TryParse(
                entrada,
                NumberStyles.AllowDecimalPoint,
                CultureInfo.InvariantCulture,
                out decimal precio
            );

            if (!precioValido || precio <= 0)
            {
                Console.WriteLine("Escribe un precio valido mayor que cero.");
                return;
            }

            Producto producto = new Producto
            {
                Nombre = nombre,
                Precio = precio
            };

            Productos.Add(producto);
            Console.WriteLine("Producto registrado correctamente.");
        }
    }
}
