using System;
using System.Collections.Generic;
using System.Text;

namespace PatronesDiseño.Creacion.Builder
{
    /// <summary>
    /// La fabrica, es la clase que obtiene el builder, y llama a los métodos para crear el objeto en concreto.
    /// </summary>
    public class Fabrica
    {
        private ABuilder vehiculoBuilder;

        public Fabrica(ABuilder constructor)
        {
            this.vehiculoBuilder = constructor;
        }

        public Vehiculo getVehiculo()
        {
            return this.vehiculoBuilder.getVehiculo();
        }

        public void construirVehiculo()
        {
            this.vehiculoBuilder.buildColor();
            this.vehiculoBuilder.buildMarca();
            this.vehiculoBuilder.buildTipoCombustible();
        }
    }
}
