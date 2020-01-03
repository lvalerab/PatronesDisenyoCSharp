using System;
using System.Collections.Generic;
using System.Text;

namespace PatronesDiseño.Estructurales.Decorator
{

    /// <summary>
    /// Este es un decorador, que permite dibujar con un color de fondo
    /// </summary>
    public class DecoradorColorFondo:DecoradorVisual
    {
        protected System.ConsoleColor color;
        public DecoradorColorFondo(ControlVisual controlVisual,System.ConsoleColor color):base(controlVisual)
        {
            this.color = color;
        }

        public void DibujaConFondo()
        {
            ConsoleColor colorAnt = System.Console.BackgroundColor;
            System.Console.BackgroundColor = this.color;
            this.controlVisual.Dibujar();
            System.Console.BackgroundColor = colorAnt;
        }
        
    }
}
