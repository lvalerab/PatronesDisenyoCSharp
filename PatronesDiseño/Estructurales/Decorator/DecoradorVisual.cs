using System;
using System.Collections.Generic;
using System.Text;

namespace PatronesDiseño.Estructurales.Decorator
{
    //Define una clase donde se heredaran todos los decoradores 
    public abstract class DecoradorVisual : IComponente
    {
        //Hace una referencia al control visual que queremos decorar
        protected ControlVisual controlVisual;

        public DecoradorVisual(ControlVisual controlVisual)
        {
            this.controlVisual = controlVisual;
        }

        public void Dibujar() {
            this.controlVisual.Dibujar();
        }
    }
}
