using System;
using System.Collections.Generic;
using System.Text;

namespace PatronesDiseño.Creacion.Builder
{
    /// <summary>
    /// Implementa el builder del tipo vehiculo honda
    /// </summary>
    public class VehiculoHondaBuilder:ABuilder
    {
        public VehiculoHondaBuilder()
        {
            this.vehiculo = new Vehiculo();
        }

        public override void buildColor()
        {
            this.vehiculo.Color = "Gris";
        }

        public override void buildMarca()
        {
            this.vehiculo.Nombre = "Honda";
        }

        public override void buildTipoCombustible()
        {
            this.vehiculo.TipoCombustible = "Gasolina 95";
        }
    }
}
