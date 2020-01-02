using System;
using System.Collections.Generic;
using System.Text;

namespace PatronesDiseño.Creacion.Factory
{
    public class Producto2 : IProducto
    {
        public void ImprimeProducto()
        {
            System.Console.WriteLine("Se ha creado el producto {0}", this.GetType().Name);
        }
    }
}
