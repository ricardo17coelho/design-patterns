using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZbW.DesignPatterns.Aufgabe_10_GOF_Pattern._01_FactoryMethod
{
    public class BratwurstPizza : IPizza
    {
        public void Price(decimal price)
        {
            Console.WriteLine("BratwurstPizza price is: " + price.ToString() + ".- CHF");
        }
    }
}
