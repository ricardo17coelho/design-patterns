using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZbW.DesignPatterns.Strategy
{
    public class AbsolutePricingStrategy : IPricingStrategy
    {
        private readonly decimal _limit;
        private readonly decimal _absoluteDiscount;
        public AbsolutePricingStrategy(decimal limit, decimal absoluteDiscount)
        {
            _limit = limit;
            _absoluteDiscount = absoluteDiscount;
        }

        public decimal GetDiscount(Sale sale)
        {
            throw new NotImplementedException();
        }

        public decimal GetTotal(Sale sale)
        {
            if (sale.Amount >= _limit)
            {
                return sale.Amount - _absoluteDiscount;
            }
            return sale.Amount;
        }
    }
}
