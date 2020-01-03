using System;
using System.Collections.Generic;
using System.Text;

namespace PatronesDiseño.Estructurales.Decorator
{
    public class DecoradorBorderDoble:DecoradorVisual
    {
        public DecoradorBorderDoble(ControlVisual controlVisual):base(controlVisual)
        {

        }

        //Nuevo metodo para dibujar con doble linea

        public void DibujaMarcoDoble()
        {            
            System.Console.CursorTop = this.controlVisual.y;            
            for (int hi = this.controlVisual.y; hi <= this.controlVisual.y + this.controlVisual.h; hi++)
            {
                System.Console.CursorLeft = this.controlVisual.x;
                string relleno = " ";
                if (hi == this.controlVisual.y || hi == this.controlVisual.y+this.controlVisual.h)
                {
                    relleno = "=";
                }
                System.Console.Write("*");
                for (int hx = this.controlVisual.x + 1; hx < this.controlVisual.x+ this.controlVisual.w; hx++)
                {
                    System.Console.Write(relleno);
                }
                System.Console.WriteLine("*");
            }            
        }
    }
}
