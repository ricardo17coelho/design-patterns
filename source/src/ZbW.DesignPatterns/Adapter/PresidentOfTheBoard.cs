using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZbW.DesignPatterns.Adapter
{
    public class PresidentOfTheBoard
    {
        private readonly decimal _bonus;

        public PresidentOfTheBoard(decimal bonus)
        {
            _bonus = bonus;
        }

        public decimal Bonus => _bonus;
    }
}
