using System;
using System.Collections.Generic;

namespace CarritoCompras
{
    class Program
    {
        static void Main(string[] args)
        {
            var bebidas = new Categoria("Bebidas", "Bebidas frías y calientes");
            var snacks = new Categoria("Snacks", "Comidas para picar");

            var categorias = new List<Categoria> { bebidas, snacks };
            var productos = new List<Producto>
            {
                new Producto(1, "Coca-Cola", 800m, 10, bebidas),
                new Producto(2, "Pepsi", 750m, 5, bebidas),
                new Producto(3, "Doritos", 600m, 8, snacks),
                new Producto(4, "Maní salado", 400m, 12, snacks)
            };

            var tienda = new Tienda(productos, categorias);
            var carrito = new Carrito(new List<ItemCarrito>(), tienda);

            bool salir = false;
            while (!salir)
            {
                Console.WriteLine("\n--- Menú ---");
                Console.WriteLine("1. Ver categorías disponibles");
                Console.WriteLine("2. Ver productos disponibles");
                Console.WriteLine("3. Ver productos por categoría");
                Console.WriteLine("4. Agregar producto al carrito");
                Console.WriteLine("5. Eliminar producto del carrito");
                Console.WriteLine("6. Ver contenido del carrito");
                Console.WriteLine("7. Ver total a pagar");
                Console.WriteLine("8. Finalizar compra");
                Console.WriteLine("9. Salir");
                Console.Write("Seleccione una opción: ");

                string opcion = Console.ReadLine();
                Console.WriteLine();

                
            }
    }
}
