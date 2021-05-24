using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZbW.DesignPatterns.Aufgabe_10_GOF_Pattern._01_FactoryMethod
{
    public class ConcretePizzaFactory : PizzaFactory
    {
        public override IPizza GetPizza(string Pizza)
        {
            switch (Pizza)
            {
                case "BratwurstPizza":
                    return new BratwurstPizza();
                case "PaellaPizza":
                    return new PaellaPizza();
                default:
                    throw new ApplicationException(string.Format("Pizza '{0}' cannot be created", Pizza));
            }

        }
    }
}
