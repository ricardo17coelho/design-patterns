using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZbW.DesignPatterns.Strategy
{
    public class PercentageDiscountStrategy : IPricingStrategy
    {
        private readonly decimal _percentage;

        public PercentageDiscountStrategy(decimal percentage)
        {
            _percentage = percentage;
        }

        public decimal GetDiscount(Sale sale)
        {
            return sale.Amount / 100m * _percentage;
        }
    }
}
