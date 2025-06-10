using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarritoCompras
{
    public class ItemCarrito
    {
        public Producto Producto { get; set; }
        public int Cantidad { get; set; }

        public ItemCarrito(Cantidad cantidad, Producto producto)
        {
            Cantidad = cantidad;
            Producto = producto;
        }

        public void AgregarProducto(int codigo, int cant)
        {
            var existeEnTienda = Tienda.Productos.FirstOrDefault(p => p.Codigo == codigo);
            if (existeEnTienda == null)
            {
                Console.WriteLine("No existe el producto.");
                return;
            }

            var existeEnCarrito = Productos.FirstOrDefault(p => p.Codigo == codigo);
            if(existeEnCarrito != null) 
            { 
                existeEnCarrito.Cantidad += cantidad;
            }
            else
            {
                Productos.Add(existeEnTienda);
            }
        }

    }
}
