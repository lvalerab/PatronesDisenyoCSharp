using System;
using System.Collections.Generic;
using System.Text;

namespace PatronesDiseño.Creacion.Prototype
{
    public abstract class Prototipo
    {
        public String variable { get; set; }

        public Prototipo(string variable)
        {
            this.variable = variable;
        }

        public abstract Prototipo Clonar();

        public void ImprimeVariable()
        {
            System.Console.WriteLine("variable : {0}", this.variable);
        }
    }
}
