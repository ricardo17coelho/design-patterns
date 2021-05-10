using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZbW.DesignPatterns.Adapter
{
    public class EmployeeObjectAdapter : IEmployee
    {
        private readonly PresidentOfTheBoard _presidentOfTheBoard;

        public EmployeeObjectAdapter(PresidentOfTheBoard presidentOfTheBoard)
        {
            _presidentOfTheBoard = presidentOfTheBoard;
        }

        public decimal GetSalary()
        {
            return _presidentOfTheBoard.Bonus;
        }
    }
}
