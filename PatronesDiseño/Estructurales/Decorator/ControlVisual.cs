using System;
using System.Collections.Generic;
using System.Text;

namespace PatronesDiseño.Estructurales.Decorator
{
    public abstract class ControlVisual : IComponente
    {
        public int x, y, h, w;

        public ControlVisual(int x, int y, int h, int w)
        {
            this.x = x;
            this.y = y;
            this.h = h;
            this.w = w;
        }

        public virtual void Dibujar()
        {            
            System.Console.CursorTop = this.y;
            for(int hi=this.y;hi<=this.y+this.h;hi++)
            {
                System.Console.CursorLeft = this.x;
                string relleno = " ";
                if(hi==this.y || hi==this.y+this.h)
                {
                    relleno = "-";  
                } 
                System.Console.Write("*");
                for (int hx = this.x + 1; hx < this.x+this.w; hx++)
                {
                    System.Console.Write(relleno);
                }
                System.Console.WriteLine("*");
            }
        }
    }
}
