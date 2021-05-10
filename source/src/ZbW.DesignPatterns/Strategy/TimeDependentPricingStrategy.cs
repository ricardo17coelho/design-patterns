using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZbW.DesignPatterns.Strategy
{
    public class TimeDependentPricingStrategy : IPricingStrategy
    {
        private readonly DateTime _dateTime;
        private readonly decimal _percentage;

        public TimeDependentPricingStrategy(DateTime dateTime, decimal percentage)
        {
            _dateTime = dateTime;
            _percentage = percentage;
        }

        public decimal GetDiscount(Sale sale)
        {
            if (_dateTime.Hour < 12)
            {
                return _percentage;
            }
            return _percentage * 2;
        }
    }
}
