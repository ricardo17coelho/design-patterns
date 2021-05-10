using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZbW.DesignPatterns.Strategy
{
    public class NullDiscountStrategy : IPricingStrategy
    {
        public decimal GetDiscount(Sale sale)
        {
            return 0m;
        }
    }
}
