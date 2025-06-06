using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarritoCompras
{
    class Carrito
    {
        public List<ItemCarrito> Productos { get; set; } = new List<ItemCarrito>();

        public Carrito(List<ItemCarrito> productos) {
            Productos = productos;
        }
    }
}
