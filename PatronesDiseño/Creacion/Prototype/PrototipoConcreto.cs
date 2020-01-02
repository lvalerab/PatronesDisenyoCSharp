using System;
using System.Collections.Generic;
using System.Text;

namespace PatronesDiseño.Creacion.Prototype
{
    public class PrototipoConcreto:Prototipo
    {
        public PrototipoConcreto(string variable):base(variable)
        {

        }


        public override Prototipo Clonar()
        {
            return new PrototipoConcreto(this.variable); //Hacemos una copia de todas las propiedades y las devolvemos;
        }
    }
}
