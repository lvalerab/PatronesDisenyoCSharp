using System;
using System.Collections.Generic;
using System.Text;

namespace PatronesDiseño.Creacion.Builder
{
    /// <summary>
    /// Establece la base de un vehiculo
    /// </summary>
    public class Vehiculo
    {
        public String Nombre { get; set; }
        public String TipoCombustible { get; set; }
        public String Color { get; set; }

        public void ImprimeVehiculo()
        {
            System.Console.WriteLine("Nombre {0}, color {1}, tipo combustible {2}", this.Nombre, this.Color, this.TipoCombustible);
        }

    }
}
