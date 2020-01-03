using System;
using System.Collections.Generic;
using System.Text;

namespace PatronesDiseño.Comportamiento.ChainOfResponsability
{
    public abstract class Manejador
    {
        protected List<Manejador> _sucesores;
        protected int NIVEL_SOLDADO;

        public Manejador(int NIVEL_SOLDADO)
        {
            this.NIVEL_SOLDADO = NIVEL_SOLDADO;
            this._sucesores = new List<Manejador>();
        }

        public void AddSucesor(Manejador sucesor)
        {
            this._sucesores.Add(sucesor);
        }

        public abstract void Avisar(int NIVEL_AVISO, String Mensaje);

    }
}
