using System;
using System.Collections.Generic;
using System.Text;

namespace PatronesDiseño.Creacion.Factory
{
    /// <summary>
    /// La interfaz producto, define el contrato de cada uno de los productos.
    /// </summary>
    public interface IProducto
    {
        public void ImprimeProducto();
    }
}
