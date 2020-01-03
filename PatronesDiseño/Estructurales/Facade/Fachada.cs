using System;
using System.Collections.Generic;
using System.Text;

namespace PatronesDiseño.Estructurales.Facade
{
    /// <summary>
    /// La clase fachada, comunica las clases complejas para hacer operaciones simples, de tal forma, que las comunicaciones entre las clases complejas sean transparentes
    /// </summary>
    public class Fachada
    {

        public void RealizaOperacionCompleja()
        {
            ClaseAccionA ca = new ClaseAccionA();
            ClaseAccionB cb = new ClaseAccionB();
            ca.OperacionClaseA();
            System.Console.WriteLine("El resultado de la operacion es {0}",cb.OperacionClaseB(ca));
        }
    }
}
