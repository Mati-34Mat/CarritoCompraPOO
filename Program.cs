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



        }
    }
}
