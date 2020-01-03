using System;
using System.Collections.Generic;
using System.Text;

namespace PatronesDiseño.Comportamiento.ChainOfResponsability
{
    public class Soldado : Manejador
    {
        public Soldado() : base(0)
        {

        }

        public override void Avisar(int NIVEL_AVISO, string Mensaje)
        {
            if (NIVEL_AVISO >= this.NIVEL_SOLDADO)
            {
                System.Console.WriteLine("Peticion atendida por {0}, mensaje {1}", this.GetType().Name, Mensaje);
            }
            else
            {
                if (this._sucesores.Count > 0)
                {
                    foreach (Manejador m in this._sucesores)
                    {
                        m.Avisar(NIVEL_AVISO, Mensaje);
                    }
                }
                else
                {
                    System.Console.WriteLine("No existen más sucesores, el mensaje no sera atenido");
                }
            }
        }
    }
}
