using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using Xunit;
using ZbW.DesignPatterns.Strategy;

namespace ZbW.DesignPatterns.Tests.Strategy
{
    public class SaleTests
    {
        [Fact]
        public void GetTotal_WhenTotal100And10PercentDiscount_Then90()
        {
            // Arrange
            var sale = new Sale(100, new PercentagePricingStrategy(10));

            // Act
            var result = sale.GetTotal();

            // Assert
            result.Should().Be(90);
        }

        [Fact]
        public void GetDiscount_WhenTotalIsOverLimit_Then80()
        {
            // Arrange
            var absolutePricingStrategy = new AbsolutePricingStrategy(100M, 20M);

            // Act
            var result = absolutePricingStrategy.GetTotal(new Sale(100, new PercentagePricingStrategy(10)));

            // Assert
            result.Should().Be(80);
        }

        [Fact]
        public void GetTotal_WhenTotal100And20TimeDependentPercentageAtAM_Then80()
        {
            // Arrange
            var sale = new Sale(100, new TimeDependentPricingStrategy(DateTime.MinValue, 20));

            // Act
            var result = sale.GetTotal();

            // Assert
            result.Should().Be(80);
        }

        [Fact]
        public void GetTotal_WhenTotal100And20TimeDependentPercentageAtPM_Then60()
        {
            // Arrange
            var sale = new Sale(100, new TimeDependentPricingStrategy(DateTime.MaxValue, 20));

            // Act
            var result = sale.GetTotal();

            // Assert
            result.Should().Be(60);
        }
    }
}
