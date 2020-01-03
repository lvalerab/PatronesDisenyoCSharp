using System;
using System.Collections.Generic;
using System.Text;

namespace PatronesDiseño.Estructurales.AdapterOrWrapper
{
    public class Adaptador:INewClass
    {
        private IOldClass _oldInstancia;

        public Adaptador(IOldClass oldInstancia)
        {
            this._oldInstancia = oldInstancia;
        }

        public void NewMethod()
        {
            System.Console.WriteLine("Adapta el metodo old al new");
            this._oldInstancia.OldMethod();
        }
    }
}
