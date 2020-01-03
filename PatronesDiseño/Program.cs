
using System;
using System.Collections.Generic;

namespace PatronesDiseño
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
            Console.WriteLine("=============================================");
            Console.WriteLine(" PATRONES DE DISEÑO  -   Creacion");
            Console.WriteLine("=============================================");
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("[Maximice la pantalla y Pulse una tecla para continuar]");
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
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("=============================================");
            Console.WriteLine(" PATRONES DE DISEÑO  -   Estructurales");
            Console.WriteLine("=============================================");
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("[Pulse una tecla para continuar]");
            
            #region "Adapter"
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Estructurales -> Adapter o Wrapper");
            Console.WriteLine("Solucion: Intenta adaptar una instancia de una clase a otra.");
            Console.WriteLine("Ejemplo");
            PatronesDiseño.Estructurales.AdapterOrWrapper.ClaseVieja claseVieja = new Estructurales.AdapterOrWrapper.ClaseVieja();
            PatronesDiseño.Estructurales.AdapterOrWrapper.Adaptador adaptador = new Estructurales.AdapterOrWrapper.Adaptador(claseVieja);
            adaptador.NewMethod();
            #endregion

            #region "Adapter"
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Estructurales -> Decorador");
            Console.WriteLine("Solucion: Amplia funcionalidad sin reescribir la clase origen");
            Console.WriteLine("Ejemplo");
            PatronesDiseño.Estructurales.Decorator.TextComponent textComponent = new Estructurales.Decorator.TextComponent(2, 3, 4, 10, "Sin decorador");
            textComponent.Dibujar();
            textComponent = new Estructurales.Decorator.TextComponent(2, 12, 4, 10, "Decorador border doble");
            PatronesDiseño.Estructurales.Decorator.DecoradorBorderDoble bdDecorator = new Estructurales.Decorator.DecoradorBorderDoble(textComponent);
            bdDecorator.DibujaMarcoDoble();
            textComponent = new Estructurales.Decorator.TextComponent(2, 20, 4, 10, "Decorador fondo");
            PatronesDiseño.Estructurales.Decorator.DecoradorColorFondo dcDecorator = new Estructurales.Decorator.DecoradorColorFondo(textComponent,ConsoleColor.White);
            dcDecorator.DibujaConFondo();            
            #endregion


            #region "Bridge"
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Estructurales -> Bridge");
            Console.WriteLine("Solucion: Hace de paso de información entre dos clases diferentes");
            Console.WriteLine("Ejemplo");
            PatronesDiseño.Estructurales.Bridge.ClasePuente[] cp = {
                                                                    new Estructurales.Bridge.ClasePuente(new Estructurales.Bridge.ImprementacionConcretaA()),
                                                                    new Estructurales.Bridge.ClasePuente(new Estructurales.Bridge.ImplementacionConcretaB())
                                                                   };
            foreach(var c in cp)
            {
                c.Operacion();
            }
            #endregion

            #region "Facade"
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Estructurales -> Facade");
            Console.WriteLine("Solucion: Intenta definir una interfaz/clase para simplificar operaciones entre un subsistemas de clases mas complejos");
            Console.WriteLine("Ejemplo");
            PatronesDiseño.Estructurales.Facade.Fachada fachada = new Estructurales.Facade.Fachada();
            fachada.RealizaOperacionCompleja();
            #endregion


            #region "Composite"
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Estructurales -> composite");
            Console.WriteLine("Solucion: Define la dependencia de clases jerarquicas que tiene que hacer una misma accion, por ejemplo, pintar una pantalla");
            Console.WriteLine("Ejemplo [Pulse una tecla]");
            Console.Clear();
            int antBufferWidth = Console.BufferWidth;
            int antBufferHeigth = Console.BufferHeight;
            PatronesDiseño.Estructurales.Composite.TextComponent tx = new Estructurales.Composite.TextComponent(10, 10, 10, 1, "Hola mundo");            
            PatronesDiseño.Estructurales.Composite.GraphComponente gx = new Estructurales.Composite.GraphComponente(10, 16, 20, 20, 10);
            PatronesDiseño.Estructurales.Composite.TextComponent tx2 = new Estructurales.Composite.TextComponent(10, 36, 10, 1, "Componente texto, debajo grafica");
            PatronesDiseño.Estructurales.Composite.ReglaComponente rg = new Estructurales.Composite.ReglaComponente();
            PatronesDiseño.Estructurales.Composite.ContenedorComponente marco = new Estructurales.Composite.ContenedorComponente(2, 2, 100, 40);
            marco.AddComponente(tx);
            marco.AddComponente(tx2);
            marco.AddComponente(gx);
            rg.AddComponente(marco);
            rg.Dibujar();
            Console.ReadKey();
            #endregion

            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("=============================================");
            Console.WriteLine(" PATRONES DE DISEÑO  -   COMPORTAMIENTO");
            Console.WriteLine("=============================================");
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("[Pulse una tecla para continuar]");

            #region "Facade"
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Comportamiento -> Cadena de responsabilidad");
            Console.WriteLine("Solucion: Soluciona el problema de enviar un mensaje dentro de una jerarquia de objetos, que activará ciertos objetos al que vaya dirigido el mensaje");
            Console.WriteLine("Ejemplo");
            PatronesDiseño.Comportamiento.ChainOfResponsability.Capitan capitan = new Comportamiento.ChainOfResponsability.Capitan();
            PatronesDiseño.Comportamiento.ChainOfResponsability.Sargento sargento1 = new Comportamiento.ChainOfResponsability.Sargento();
            PatronesDiseño.Comportamiento.ChainOfResponsability.Sargento sargento2 = new Comportamiento.ChainOfResponsability.Sargento();
            List<PatronesDiseño.Comportamiento.ChainOfResponsability.Cabo> cabos1 = new List<Comportamiento.ChainOfResponsability.Cabo>();
            List<PatronesDiseño.Comportamiento.ChainOfResponsability.Cabo> cabos2 = new List<Comportamiento.ChainOfResponsability.Cabo>();
            for (int i=0;i<3;i++)
            {
                PatronesDiseño.Comportamiento.ChainOfResponsability.Cabo aux = new Comportamiento.ChainOfResponsability.Cabo();
                for(int j=0;j<4;j++)
                {
                    PatronesDiseño.Comportamiento.ChainOfResponsability.Soldado soldado = new Comportamiento.ChainOfResponsability.Soldado();
                    aux.AddSucesor(soldado);
                }
                cabos1.Add(aux);
                PatronesDiseño.Comportamiento.ChainOfResponsability.Cabo aux2 = new Comportamiento.ChainOfResponsability.Cabo();
                for (int j = 0; j < 4; j++)
                {
                    PatronesDiseño.Comportamiento.ChainOfResponsability.Soldado soldado = new Comportamiento.ChainOfResponsability.Soldado();
                    aux2.AddSucesor(soldado);
                }
                cabos2.Add(aux2);
            }
            foreach(var c in cabos1)
            {
                sargento1.AddSucesor(c);
            }
            foreach(var c in cabos2)
            {
                sargento2.AddSucesor(c);
            }

            capitan.AddSucesor(sargento1);
            capitan.AddSucesor(sargento2);

            ///Mandamos el mensaje con el nivel superior
            capitan.Avisar(2000, "Prepara la tropa");
            capitan.Avisar(700, "Avisar a vuestros cabos");
            capitan.Avisar(400, "Soldados preparados");
            capitan.Avisar(100, "A por el pastel :-D");
            #endregion

            Console.ReadKey();
        }
    }
}
