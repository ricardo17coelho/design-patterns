using System;
using System.Collections.Generic;
using System.Linq;

namespace ZbW.DesignPatterns.Adapter
{
    public class EmployeeManager
    {
        protected List<IEmployee> _employees;


        public EmployeeManager()
        {
            _employees = new List<IEmployee>();
        }

        public void Add(IEmployee employee)
        {
            this._employees.Add(employee);
        }

        public void Remove(IEmployee employee)
        {
            this._employees.Remove(employee);
        }

        public decimal PaySalaries()
        {
            var total = _employees.Sum(e => e.GetSalary());
            Console.WriteLine(total);
            return total;
        }
    }
}
