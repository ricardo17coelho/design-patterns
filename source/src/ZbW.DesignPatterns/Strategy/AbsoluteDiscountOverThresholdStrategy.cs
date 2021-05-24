using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZbW.DesignPatterns.Strategy
{
    public class AbsoluteDiscountOverThresholdStrategy : IPricingStrategy
    {
        private readonly decimal _threshold;
        private readonly decimal _absoluteDiscount;

        public AbsoluteDiscountOverThresholdStrategy(decimal threshold, decimal absoluteDiscount)
        {
            _threshold = threshold;
            _absoluteDiscount = absoluteDiscount;
        }

        public decimal GetDiscount(Sale sale)
        {
            if (sale.Amount >= _threshold)
            {
                return _absoluteDiscount;
            }

            return 0m;
        }
    }
}
