using System;
using ZbW.DesignPatterns.Aufgabe_10_GOF_Pattern._01_FactoryMethod;
using ZbW.DesignPatterns.Aufgabe_10_GOF_Pattern._02_AbstractFactory;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- INIT ---");
            var newLine = "\n";
            Console.WriteLine(newLine + "Aufgabe 10-01: FctoryMethod");
            PizzaFactory factory = new ConcretePizzaFactory();

            IPizza bratwurstPizza = factory.GetPizza("BratwurstPizza");
            bratwurstPizza.Price(10.5m);

            IPizza paellaPizza = factory.GetPizza("PaellaPizza");
            paellaPizza.Price(13.50m);



            Console.WriteLine(newLine + "Aufgabe 10-02: AbstractFactory");
            IPizzaFactory stGallen = new StGallenFactory();
            PizzaClient stGallenClient = new PizzaClient(stGallen, "BratwurstPizza");

            Console.WriteLine("*******  StGallen **********");
            Console.WriteLine(stGallenClient.GetNonVegiePizzaName());
            Console.WriteLine(stGallenClient.GetVegiePizzaName());

            stGallenClient = new PizzaClient(stGallen, "MargheritaPizza");
            Console.WriteLine(stGallenClient.GetNonVegiePizzaName());
            Console.WriteLine(stGallenClient.GetVegiePizzaName());


            Console.WriteLine("******* Valencia **********");
            IPizzaFactory valenciaFactory = new ValenciaFactory();
            PizzaClient valenciaFactoryClient = new PizzaClient(valenciaFactory, "PaellaPizza");
            Console.WriteLine(valenciaFactoryClient.GetNonVegiePizzaName());
            Console.WriteLine(valenciaFactoryClient.GetVegiePizzaName());

            valenciaFactoryClient = new PizzaClient(valenciaFactory, "PepperoniPizza");
            Console.WriteLine(valenciaFactoryClient.GetNonVegiePizzaName());
            Console.WriteLine(valenciaFactoryClient.GetVegiePizzaName());

            Console.ReadKey();

            Console.ReadKey();
        }
    }
}
