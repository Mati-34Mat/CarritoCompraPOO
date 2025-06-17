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

        public Carrito(List<ItemCarrito> productos) {
            Productos = productos;
        }

        public void AgregarProducto(int codigo, int cant)
        {
            var existeEnTienda = Tienda.Productos.FirstOrDefault(p => p.Codigo == codigo);
            if (existeEnTienda == null)
            {
                Console.WriteLine("No existe el producto.");
                return;
            }

            if (cant <= 0)
            {
                Console.WriteLine("Cantidad inválida.");
                return;
            }

            if (existeEnTienda.Stock < cant)
            {
                Console.WriteLine("No hay suficiente stock disponible.");
                return;
            }

            var existeEnCarrito = Productos.FirstOrDefault(ic => ic.Producto.Codigo == codigo);
            if (existeEnCarrito != null)
            {
                if (existeEnTienda.Stock < existeEnCarrito.Cantidad + cant)
                {
                    Console.WriteLine("No hay suficiente stock para esa cantidad total.");
                    return;
                }
                existeEnCarrito.Cantidad += cant;
            }
            else
            {
                Productos.Add(new ItemCarrito(existeEnTienda, cant));
            }
        }

        public void EliminarProducto(int codigo)
        {
            var existe = Productos.FirstOrDefault(p => p.Producto.Codigo == codigo);
            if (existe == null)
            {
                Console.WriteLine("El producto no está en el carrito.");
            }
            else
            {
                Productos.Remove(existe);
                Console.WriteLine("Producto eliminado del carrito.");
            }
        }

        public void MostrarCarrito()
        {
            if (!Productos.Any())
            {
                Console.WriteLine("El carrito está vacío.");
                return;
            }

            Console.WriteLine("Contenido del carrito:");
            foreach (var item in Productos)
            {
                Console.WriteLine($"{item.Producto.Codigo} - {item.Producto.Nombre} x {item.Cantidad} unidades - Precio unitario: ${item.Producto.Precio} - Subtotal: ${item.Subtotal():0.00}");
            }
        }

        public void MostrarTotal()
        {
            decimal totalSinIVA = Productos.Sum(item => item.Subtotal());
            decimal totalConIVA = totalSinIVA * 1.21m;

            Console.WriteLine($"Total a pagar (con IVA): ${totalConIVA:0.00}");
        }

        public void FinalizarCompra()
        {
            foreach (var item in Productos)
            {
                item.Producto.Stock -= item.Cantidad;
            }
            Console.WriteLine("Compra finalizada con éxito.");
            MostrarTotal();
            Productos.Clear();
        }
    }
}
