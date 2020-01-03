using System;
using System.Collections.Generic;
using System.Text;

namespace PatronesDiseño.Estructurales.Facade
{
    public class ClaseAccionA
    {
        int numero;
        public void OperacionClaseA()
        {
            Random rd = new Random();
            this.numero = rd.Next();
        }

        public int OperacionClaseA2()
        {
            return this.numero * 2;
        }
    }
}
