using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarritoCompras
{
    public class Carrito
    {
        public List<ItemCarrito> Productos { get; set; } = new List<ItemCarrito>();
        public Tienda Tienda;

        public Carrito(List<ItemCarrito> productos, Tienda tienda) {
            Productos = productos;
            Tienda = tienda;
        }

        public void AgregarProducto(int codigo, int cant)
        {
            var existeEnTienda = Tienda.Productos.FirstOrDefault(p => p.Codigo == codigo);
            if (existeEnTienda == null)
            {
                Console.WriteLine("No existe el producto.");
                return;
            }

            var existeEnCarrito = Productos.FirstOrDefault(ic => ic.Producto.Codigo == codigo);
            if (existeEnCarrito != null) 
            { 
                existeEnCarrito.Cantidad += cant;
            }
            else
            {
                Productos.Add(new ItemCarrito(existeEnTienda, cant));
            }
        }

        public void EliminarProducto(Producto producto)
        {
            var existe = Productos.FirstOrDefault(p => p.Producto.Codigo == producto.Codigo);
            if (existe == null)
            {
                Console.WriteLine("El producto no está en el carrito.");
            }
            else
            {
                Productos.Remove(existe);
            }
        }

        public void MostrarCarrito(Carrito carrito)
        {
            Console.WriteLine("Lista de items en el carrito:");
            for (int i = 0; i < Productos.Count; i++)
            {
                var itemCarrito = Productos[i];
                Console.WriteLine($"{i + 1}. {itemCarrito.Producto.Nombre} - ${itemCarrito.Producto.Precio}");
            }
        }

        public void MostrarTotal()
        {
            decimal suma = 0;
            for (int i = 0; i < Productos.Count; i++)
            {
                var producto = Productos[i];
                suma += producto.Precio;
            }

            Console.WriteLine($"El total a pagar es: ${suma}");
        }
    }
}
