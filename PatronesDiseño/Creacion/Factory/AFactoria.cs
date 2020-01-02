using System;
using System.Collections.Generic;
using System.Text;

namespace PatronesDiseño.Creacion.Factory
{
    //La clase factoria se encarga de centralizar la forma de crear los objetos dependiendo del parámetro.
    public abstract class AFactoria
    {
        public static IProducto Factoria(string tipo) {
            IProducto resultado = null;
            switch(tipo)
            {
                case "1":
                    resultado=new Producto1();
                    break;
                case "2":
                    resultado=new Producto2();
                    break;
            }
            return resultado;
        }
    }
}
