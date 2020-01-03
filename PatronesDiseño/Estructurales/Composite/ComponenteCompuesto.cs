using System;
using System.Collections.Generic;
using System.Text;

namespace PatronesDiseño.Estructurales.Composite
{

    //El componente compuesto, se comporta como un componente, pero ademas, puede contener otros, es la base del composite
    public abstract class ComponenteCompuesto : IComponente
    {
        protected List<IComponente> componentes;

        public ComponenteCompuesto()
        {
            this.componentes = new List<IComponente>();
        }

        public void AddComponente(IComponente c)
        {
            this.componentes.Add(c);
        }

        public void RemoveComponente(IComponente c)
        {
            this.componentes.RemoveAt(this.componentes.IndexOf(c));
        }

        public virtual void Dibujar()
        {
            //Dibujamos los hijos
            foreach(IComponente c in this.componentes)
            {
                c.Dibujar();
            }
        }
    }
}
