using System;
using System.Collections.Generic;
using System.Text;

namespace PatronesDiseño.Creacion.AbstractFactory
{
    /// <summary>
    /// La factoria concreta 1, crea los objetos marcados como 1 de los tipos A y B
    /// </summary>
    public class FactoriaConcreta1 : IAbstractFactory
    {
        public IClaseTipoA crearProductoA()
        {
            return new ProductoA1();
        }

        public IClaseTipoB crearProductoB()
        {
            return new ProductoB1();
        }
    }
}
