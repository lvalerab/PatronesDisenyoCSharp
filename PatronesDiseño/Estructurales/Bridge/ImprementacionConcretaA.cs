using System;
using System.Collections.Generic;
using System.Text;

namespace PatronesDiseño.Estructurales.Bridge
{
    public class ImprementacionConcretaA:Implementador
    {

        public override void OperacionImplementador()
        {
            System.Console.WriteLine("Implementacion concreta del implementacion concreata A");
        }
    }
}
