using System;
using System.Collections.Generic;
using System.Text;

namespace PatronesDiseño.Creacion.Singleton
{
    public class Singleton
    {
        private static Singleton instancia;
        private static Int32 NumeroInstancias;

        public String variable { get; set; }

        private Singleton()
        {
            
        }

        public static Singleton getInstancia()
        {
            if(Singleton.instancia!=null)
            {
                Singleton.NumeroInstancias++;
            } else
            {
                Singleton.NumeroInstancias = 1;
                Singleton.instancia = new Singleton();
            }
            return Singleton.instancia;
        }

        public void GetNumerosInstancias()
        {
            System.Console.WriteLine("Nº veces instanciados {0}, variable almacenada {1}", Singleton.NumeroInstancias, this.variable);
        }
    }
}
