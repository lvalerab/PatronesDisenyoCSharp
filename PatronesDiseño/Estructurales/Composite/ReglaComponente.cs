using System;
using System.Collections.Generic;
using System.Text;

namespace PatronesDiseño.Estructurales.Composite
{
    public class ReglaComponente:ComponenteCompuesto
    {
        public ReglaComponente():base()
        {

        }

        public override void Dibujar()
        {
            for(int i=0;i<Console.BufferWidth;i+=5)
            {
                System.Console.SetCursorPosition(i, 0);
                System.Console.Write("|");
            }
            System.Console.SetCursorPosition(System.Console.BufferWidth - System.Console.BufferWidth.ToString().Length, 0);
            System.Console.Write(System.Console.BufferWidth);
            for(int i=0;i<Console.BufferHeight;i+=5)
            {
                System.Console.SetCursorPosition(0, i);
                System.Console.Write("-");
            }
            System.Console.SetCursorPosition(0, Console.BufferHeight-1);
            System.Console.Write(Console.BufferHeight);
            base.Dibujar();
            System.Console.SetCursorPosition(0, 0);
        }

    }
}
