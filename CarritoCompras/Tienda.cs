using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CarritoCompras
{
    public static class Tienda
    {
        public static List<Producto> Productos { get; set; } = new List<Producto>();
        public static List<Categoria> Categorias { get; set; } = new List<Categoria>();

        public static void MostrarCategorias()
        {
            if (!Categorias.Any())
            {
                Console.WriteLine("No hay categorías disponibles.");
                return;
            }

            Console.WriteLine("Categorías disponibles:");
            for (int i = 0; i < Categorias.Count; i++)
            {
                var categoria = Categorias[i];
                Console.WriteLine($"{i + 1}. {categoria.Nombre} - {categoria.Descripcion}");
            }
            return;

        }

        public static void MostrarProductos()
        {
            if (!Productos.Any())
            {
                Console.WriteLine("No hay productos disponibles.");
                return;
            }

            Console.WriteLine("Productos disponibles:");
            for (int i = 0; i < Productos.Count; i++) {
                var producto = Productos[i];
                Console.WriteLine($"{i + 1}. {producto.Nombre} - Precio: ${producto.Precio} - Stock: {producto.Stock}");
            }
            return;
        }

        public static void ProductosFiltrados(Categoria categoria)
        {
            Console.WriteLine($"Productos disponibles en la categoria {categoria.Nombre}:");
            for (int i = 0; i < Productos.Count; i++) {
                var producto = Productos[i];
                if (producto.Categoria == categoria) {
                    Console.WriteLine($"{i + 1}. {producto.Nombre} - Precio: ${producto.Precio} - Stock: {producto.Stock}");
                }
            }
        }
    }
}
