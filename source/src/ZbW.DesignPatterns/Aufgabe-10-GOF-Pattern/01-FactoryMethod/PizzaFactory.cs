using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZbW.DesignPatterns.Aufgabe_10_GOF_Pattern._01_FactoryMethod
{
    public abstract class PizzaFactory
    {
        public abstract IPizza GetPizza(string Pizza);
       
    }
}
