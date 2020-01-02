using System;
using System.Collections.Generic;
using System.Text;

namespace PatronesDiseño.Creacion.AbstractFactory
{
    /// <summary>
    /// La factoria concreta 2, crea los objetos marcados como 2 de los tipos A y B
    /// </summary>
    public class FactoriaConcreta2 : IAbstractFactory
    {
        public IClaseTipoA crearProductoA()
        {
            return new ProductoA2();
        }

        public IClaseTipoB crearProductoB()
        {
            return new ProductoB2();
        }
    }
}
