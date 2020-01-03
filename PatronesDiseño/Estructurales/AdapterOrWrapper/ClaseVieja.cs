using System;
using System.Collections.Generic;
using System.Text;

namespace PatronesDiseño.Estructurales.AdapterOrWrapper
{
    public class ClaseVieja : IOldClass
    {
        public void OldMethod()
        {
            System.Console.WriteLine("Llama al metodo antiguo");
        }
    }
}
