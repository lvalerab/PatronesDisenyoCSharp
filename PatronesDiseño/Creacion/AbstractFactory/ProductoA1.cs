using System;
using System.Collections.Generic;
using System.Text;

namespace PatronesDiseño.Creacion.AbstractFactory
{
    public class ProductoA1 : IClaseTipoA
    {
        public void ImprimeClaseA()
        {
            System.Console.WriteLine("[A1] La clase {0} es de tipo {1}", this.GetType().Name, this.GetType().FullName);
        }
    }
}
