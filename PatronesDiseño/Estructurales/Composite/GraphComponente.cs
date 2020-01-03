using System;
using System.Collections.Generic;
using System.Text;

namespace PatronesDiseño.Estructurales.Composite
{
    public class GraphComponente:IComponente
    {

        public int x { get; set; }
        public int y { get; set; }
        public int w { get; set; }
        public int h { get; set; }

        public int puntos { get; set; }

        public GraphComponente(int x, int y, int w, int h, int puntos)
        {
            this.x = x;
            this.y = y;
            this.w = w;
            this.h = h;
            this.puntos = puntos;
        }

        public void Dibujar()
        {
            //Cuadrada inversa
            for(int i=0;i<Math.Max(this.puntos,this.w);i++)
            {
                try { 
                    int py = i;
                    System.Console.SetCursorPosition(this.x + i, this.y + py);
                    System.Console.Write(".");
                } catch (Exception err)
                {
                    System.Console.SetCursorPosition(0, System.Console.BufferHeight - 1);
                    System.Console.Write("Error {0}", err.Message);
                }
            }
        }


    }
}
