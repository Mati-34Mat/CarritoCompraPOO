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

                switch (opcion)
                {
                    case "1":
                        tienda.MostrarCategorias();
                        break;

                    case "2":
                        tienda.MostrarProductos();
                        break;

                    case "3":
                        tienda.MostrarCategorias();
                        Console.Write("Seleccione el número de la categoría: ");
                        if (int.TryParse(Console.ReadLine(), out int numCat) && numCat > 0 && numCat <= tienda.Categorias.Count)
                        {
                            var cat = tienda.Categorias[numCat - 1];
                            tienda.ProductosFiltrados(cat);
                        }
                        else Console.WriteLine("Categoría inválida.");
                        break;

                    case "4":
                        Console.Write("Ingrese el código del producto: ");
                        int codAgregado = int.Parse(Console.ReadLine());
                        Console.Write("Ingrese la cantidad: ");
                        int cantAgregada = int.Parse(Console.ReadLine());
                        carrito.AgregarProducto(codAgregado, cantAgregada);
                        break;

                    case "5":
                        Console.Write("Ingrese el código del producto a eliminar: ");
                        int codEliminado = int.Parse(Console.ReadLine());
                        carrito.EliminarProducto(codEliminado);
                        break;

                    case "6":
                        carrito.MostrarCarrito();
                        break;

                    case "7":
                        carrito.MostrarTotal();
                        break;

                    case "8":
                        carrito.FinalizarCompra();
                        break;

                    case "9":
                        salir = true;
                        break;

                    default:
                        Console.WriteLine("Opción inválida.");
                        break;
                }
            }
    }
}
