using System;
using System.Collections.Generic;
using System.Text;

namespace PatronesDiseño.Creacion.AbstractFactory
{
    //La interfaz define el contrato para los metodos que deben tener cada una  de las factorias concretas.
    public interface IAbstractFactory
    {
        IClaseTipoA crearProductoA();
        IClaseTipoB crearProductoB();
    }
}
