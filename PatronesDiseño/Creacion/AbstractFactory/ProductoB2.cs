﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PatronesDiseño.Creacion.AbstractFactory
{
    public class ProductoB2:IClaseTipoB
    {
        public void ImprimeClaseB()
        {
            System.Console.WriteLine("[B1] La clase {0} es de tipo {1}", this.GetType().Name, this.GetType().FullName);
        }
    }
}
