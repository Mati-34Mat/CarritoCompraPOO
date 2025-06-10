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

        public Carrito(List<ItemCarrito> productos, Tienda tienda) {
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
            var existe = Productos.FirstOrDefault(p => p.Codigo == Producto.Codigo);
            if (existe == null)
            {
                Console.WriteLine("El producto no está en el carrito.");
            }
            else
            {
                Productos.Remove(producto);
            }
        }
    }
}
