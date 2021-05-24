using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZbW.DesignPatterns.Aufgabe_10_GOF_Pattern._02_AbstractFactory
{
    public class PizzaClient
    {
        INonVegie nonVegie;
        IVegie vegie;

        public PizzaClient(IPizzaFactory factory, string type)
        {
            nonVegie = factory.GetNonVegiePizza(type);
            vegie = factory.GetVegiePizza(type);
        }

        public string GetNonVegiePizzaName()
        {
            return nonVegie.Name();
        }

        public string GetVegiePizzaName()
        {
            return vegie.Name();
        }

    }
}