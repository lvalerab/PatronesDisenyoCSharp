using System;
using System.Collections.Generic;
using System.Text;

namespace PatronesDiseño.Estructurales.Bridge
{
    public class ClasePuente:Abstraccion
    {
        private Implementador _implementador;

        public ClasePuente(Implementador implementador)
        {
            this._implementador = implementador;
        }

        public override void Operacion()
        {
            System.Console.WriteLine("Llamado al metodo puente");
            this._implementador.OperacionImplementador();
        }
    }
}
