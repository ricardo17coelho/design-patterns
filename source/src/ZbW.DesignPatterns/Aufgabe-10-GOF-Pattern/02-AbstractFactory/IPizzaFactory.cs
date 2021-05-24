using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZbW.DesignPatterns.Aufgabe_10_GOF_Pattern._02_AbstractFactory
{
    public interface IPizzaFactory
    {
        IVegie GetVegiePizza(string IVegie);
        INonVegie GetNonVegiePizza(string INonVegie);
    }
}
