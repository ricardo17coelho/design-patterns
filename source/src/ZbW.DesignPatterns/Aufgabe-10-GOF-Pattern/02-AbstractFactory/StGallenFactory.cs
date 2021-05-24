using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZbW.DesignPatterns.Aufgabe_10_GOF_Pattern._02_AbstractFactory
{
    public class StGallenFactory : IPizzaFactory
    {

        public INonVegie GetNonVegiePizza(string INonVegie)
        {
            switch (INonVegie)
            {
                case "BratwurstPizza":
                    return new BratwurstPizza();
                default:
                    throw new ApplicationException(string.Format("Pizza '{0}' cannot be created", INonVegie));
            }

        }

        public IVegie GetVegiePizza(string IVegie)
        {
            switch (IVegie)
            {
                case "PepperoniPizza":
                    return new PepperoniPizza();
                case "MargheritaPizza":
                    return new MargheritaPizza();
                default:
                    throw new ApplicationException(string.Format("Pizza '{0}' cannot be created", IVegie));
            }

        }
    }
}