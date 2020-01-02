using System;
using System.Collections.Generic;
using System.Text;

namespace PatronesDiseño.Creacion.Factory
{
    public class Producto1 : IProducto
    {
        public void ImprimeProducto()
        {
            System.Console.WriteLine("Se ha creado el Producto {0}", this.GetType().Name);
        }
    }
}
