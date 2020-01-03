using System;
using System.Collections.Generic;
using System.Text;

namespace PatronesDiseño.Estructurales.Composite
{
    //La clase componente simple, define como se comportara un componente final
    public abstract class ComponenteSimple : IComponente
    {
        public abstract void Dibujar();
    }
}
