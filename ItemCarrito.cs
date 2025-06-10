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

        public ItemCarrito(Producto producto, int cantidad)
        {
            Cantidad = cantidad;
            Producto = producto;
        }
    }
}
