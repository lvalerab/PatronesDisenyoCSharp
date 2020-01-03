using System;
using System.Collections.Generic;
using System.Text;

namespace PatronesDiseño.Estructurales.Composite
{
    public class TextComponent : IComponente
    {
        public int x { get; set; }
        public int y { get; set; }

        public int w { get; set; }

        public int h { get; set; }

        public String Texto { get; set; }

        public TextComponent(int x, int y, int w, int h, String texto)
        {
            this.x = x;
            this.y = y;
            this.w = w;
            this.h = h;
            this.Texto = texto;
        }

        public void Dibujar()
        {
            System.Console.SetCursorPosition(this.x, this.y);
            System.Console.WriteLine(this.Texto.Substring(0, Math.Max(this.w,this.Texto.Length)));
        }
    }
}
