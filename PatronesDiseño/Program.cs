
using System;

namespace PatronesDiseño
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=============================================");
            Console.WriteLine(" PATRONES DE DISEÑO");
            Console.WriteLine("=============================================");
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("[Pulse una tecla para continuar]");
            #region "Abstract Factory"
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Creacion -> Abstract factory");
            Console.WriteLine("Solucion: Intenta centrar la generación de objetos de diferente forma, pero teniendo propiedades comunes");
            Console.WriteLine("Ejemplo");
            PatronesDiseño.Creacion.AbstractFactory.FactoriaConcreta1 fc1 = new Creacion.AbstractFactory.FactoriaConcreta1();
            PatronesDiseño.Creacion.AbstractFactory.FactoriaConcreta2 fc2 = new Creacion.AbstractFactory.FactoriaConcreta2();
            PatronesDiseño.Creacion.AbstractFactory.IClaseTipoA auxTipoA = fc1.crearProductoA();
            auxTipoA.ImprimeClaseA(); //Producto caracteristica 1 del tipo A
            auxTipoA = fc2.crearProductoA();
            auxTipoA.ImprimeClaseA(); //Producto caracteristica 2 del tipo A
            PatronesDiseño.Creacion.AbstractFactory.IClaseTipoB auxTipoB = fc1.crearProductoB();
            auxTipoB.ImprimeClaseB(); //Producto caracteristica 1 del tipo B
            auxTipoB = fc2.crearProductoB();
            auxTipoB.ImprimeClaseB(); //Producto caracteristica 2 del tipo B            
            #endregion

            #region "Factory"
            Console.WriteLine("[Pulse una tecla para continuar]");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Creacion -> Factory");
            Console.WriteLine("Solucion: Centraliza la creación de objetos en ún único método");
            Console.WriteLine("Ejemplo");
            PatronesDiseño.Creacion.Factory.IProducto prod = PatronesDiseño.Creacion.Factory.AFactoria.Factoria("1");
            prod.ImprimeProducto();
            prod = PatronesDiseño.Creacion.Factory.AFactoria.Factoria("2");
            prod.ImprimeProducto();
            #endregion

            #region "Builder"
            Console.WriteLine("[Pulse una tecla para continuar]");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Creacion -> Builder");
            Console.WriteLine("Solucion: Simplifica la creación de objetos con muchos parámetros");
            Console.WriteLine("Ejemplo");
            PatronesDiseño.Creacion.Builder.VehiculoFordBuilder fordBuilder = new Creacion.Builder.VehiculoFordBuilder();
            PatronesDiseño.Creacion.Builder.VehiculoHondaBuilder hondaBuilder = new Creacion.Builder.VehiculoHondaBuilder();
            PatronesDiseño.Creacion.Builder.Fabrica fabrica = new Creacion.Builder.Fabrica(fordBuilder);
            fabrica.construirVehiculo();
            PatronesDiseño.Creacion.Builder.Vehiculo ford = fabrica.getVehiculo();
            fabrica = new Creacion.Builder.Fabrica(hondaBuilder);
            fabrica.construirVehiculo();
            PatronesDiseño.Creacion.Builder.Vehiculo honda = fabrica.getVehiculo();
            ford.ImprimeVehiculo();
            honda.ImprimeVehiculo();
            #endregion

            #region "Prototype"
            Console.WriteLine("[Pulse una tecla para continuar]");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Creacion -> Prototype");
            Console.WriteLine("Solucion: Simplifica la creación de objetos con copias de otros objetos");
            Console.WriteLine("Ejemplo");
            PatronesDiseño.Creacion.Prototype.Prototipo pc = new Creacion.Prototype.PrototipoConcreto("PC-1");
            PatronesDiseño.Creacion.Prototype.Prototipo pcc = pc.Clonar();
            PatronesDiseño.Creacion.Prototype.Prototipo pc2 = pc.Clonar();
            pc.ImprimeVariable();
            pcc.ImprimeVariable();
            pc2.ImprimeVariable();
            pc.variable = "PC-CAMBIADO1";
            pcc.variable = "PC-CAMBIADO2";
            pc2.variable = "PC-CAMBIADO3";
            pc.ImprimeVariable();
            pcc.ImprimeVariable();
            pc2.ImprimeVariable();
            #endregion

            #region "Singleton"
            Console.WriteLine("[Pulse una tecla para continuar]");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Creacion -> Singleton");
            Console.WriteLine("Solucion: Crea un objeto de instancia única");
            Console.WriteLine("Ejemplo");
            PatronesDiseño.Creacion.Singleton.Singleton sg1 = PatronesDiseño.Creacion.Singleton.Singleton.getInstancia();
            PatronesDiseño.Creacion.Singleton.Singleton sg2 = PatronesDiseño.Creacion.Singleton.Singleton.getInstancia();
            sg1.variable = "Hola";
            sg1.GetNumerosInstancias();
            sg2.GetNumerosInstancias();
            sg2.variable = "PEPE";
            sg1.GetNumerosInstancias();
            sg2.GetNumerosInstancias();
            #endregion
        }
    }
}
