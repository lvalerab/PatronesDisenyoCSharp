﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PatronesDiseño.Estructurales.Bridge
{
    public class ImplementacionConcretaB:Implementador
    {

        public override void OperacionImplementador()
        {
            System.Console.WriteLine("Implementacion concreta del caso B");
        }
    }
}
