using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CarritoCompras
{
    public class Tienda
    {
        public List<Producto> Productos { get; set; } = new List<Producto>();
        public List<Categoria> Categorias { get; set; } = new List<Categoria>();

        public Tienda (List<Producto> productos, List<Categoria> categorias)
        {
            Productos = productos;
            Categorias = categorias;
        }

        public void MostrarCategorias()
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

        public void MostrarProductos()
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

        public void ProductosFiltrados(Categoria categoria)
        {
            Console.WriteLine($"Productos disponibles en la categoria {categoria}:");
            for (int i = 0; i < Productos.Count; i++) {
                var producto = Productos[i];
                if (producto.Categoria == categoria) {
                    Console.WriteLine($"{i + 1}. {producto.Nombre} - Precio: ${producto.Precio} - Stock: {producto.Stock}");
                }
            }
        }
    }
}
