using System;
using System.Collections.Generic;
using System.Text;

namespace PatronesDiseño.Estructurales.Decorator
{
    public class TextComponent : ControlVisual
    {
        public String texto { get; set; }
        public TextComponent(int x, int y, int w, int h, string texto) : base(x, y, w, h)
        {
            this.texto = texto;
        }

        //Usamos la sobrecarga, sin usar el Decorator
        public override void Dibujar()
        {
            base.Dibujar();
            Console.CursorTop = this.y + 1;
            Console.CursorLeft = this.x + 1;
            Console.Write(this.texto.Substring(0, this.w - 1));
        }
    }
}
