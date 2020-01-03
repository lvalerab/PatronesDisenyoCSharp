using System;
using System.Collections.Generic;
using System.Text;

namespace PatronesDiseño.Estructurales.Facade
{
    public class ClaseAccionB
    {
        public int OperacionClaseB(ClaseAccionA ClaseA)
        {
            System.Console.WriteLine("Llama a la operacion de la clase B");
            return ClaseA.OperacionClaseA2() ^ 2;
        }
    }
}
