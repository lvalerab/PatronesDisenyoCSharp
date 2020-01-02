using System;
using System.Collections.Generic;
using System.Text;

namespace PatronesDiseño.Creacion.Builder
{
    /// <summary>
    /// Implementa el builder para el tipo de vehiculo ford.
    /// </summary>
    public class VehiculoFordBuilder : ABuilder
    {
        public VehiculoFordBuilder()
        {
            this.vehiculo = new Vehiculo();
        }
        public override void buildColor()
        {
            this.vehiculo.Color = "Negro";
        }

        public override void buildMarca()
        {
            this.vehiculo.Nombre = "Ford";
        }

        public override void buildTipoCombustible()
        {
            this.vehiculo.TipoCombustible = "Diesel";
        }
    }
}
