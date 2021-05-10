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

        [Theory]
        [InlineData("100", "100", "90")]
        [InlineData("100", "99", "99")]
        [InlineData("100", "101", "91")]
        public void AbsoluteDiscountOverThresholdStrategy(string limit, string amount, string expectedResult)
        {
            // Arrange
            var absolutePricingStrategy = new AbsolutePricingStrategy(decimal.Parse(limit), 10m);

            // Act
            var result = new Sale(decimal.Parse(amount), absolutePricingStrategy).GetTotal();

            // Assert
            result.Should().Be(decimal.Parse(expectedResult));
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
