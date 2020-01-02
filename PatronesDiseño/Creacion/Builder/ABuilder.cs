using System;
using System.Collections.Generic;
using System.Text;

namespace PatronesDiseño.Creacion.Builder
{
    /// <summary>
    /// Implementa los métodos basicos para construir un tipo Vehiculo
    /// </summary>
    public abstract class ABuilder
    {
        protected Vehiculo vehiculo;

        public Vehiculo getVehiculo()
        {
            return this.vehiculo;
        }

        public abstract void buildMarca();
        public abstract void buildTipoCombustible();
        public abstract void buildColor();
    }
}
