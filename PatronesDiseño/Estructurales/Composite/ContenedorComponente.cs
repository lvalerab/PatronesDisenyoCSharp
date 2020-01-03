using System;
using System.Collections.Generic;
using System.Text;

namespace PatronesDiseño.Estructurales.Composite
{
    public class ContenedorComponente:ComponenteCompuesto
    {
        public int x { get; set; }
        public int y { get; set; }
        public int w { get; set; }
        public int h { get; set; }

        public ContenedorComponente(int x, int y, int w, int h):base()
        {
            this.x = x;
            this.y = y;
            this.w = w;
            this.h = h;
        }

        public override void Dibujar()
        {
            for(int iy=0;iy<=this.h;iy++)
            {
                System.Console.SetCursorPosition(this.x, this.y+iy);
                System.Console.Write("|");
                System.Console.SetCursorPosition(this.x+this.w, this.y + iy);
                System.Console.Write("|");
                String relleno = " ";
                if(iy==0 || iy==this.h)
                {
                    relleno = "-";
                } else
                {
                    relleno = " ";
                }
                for(int ix=1;ix<this.w;ix++)
                {
                    System.Console.SetCursorPosition(this.x + ix, this.y + iy);
                    System.Console.Write(relleno);
                }
            }
            base.Dibujar();
        }
    }
}
