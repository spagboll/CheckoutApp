using CheckoutApp.Domain.BaseTypes;
using CheckoutApp.Domain.Products;
using FluentAssertions;
using NUnit.Framework;
using System;

namespace CheckoutApp.Domain.Tests
{
    public class PriceTests
    {
        [Test]
        public void Price_Is_A_Value()
        {
            var sut = new Price(25.00m);
            sut.Should().BeAssignableTo<ValueBase<Price>>();
        }

        [Test]
        public void Price_Cannot_Be_Negative()
        {
            Action act = () => new Price(-1.00m);
            act.Should().Throw<ArgumentOutOfRangeException>("negative prices are not supported")
                .And.ParamName.Should().Be("price");                
        }

        [Test]
        public void Same_Prices_Are_Equal()
        {
            var sut = new Price(10.00m);
            var sut2 = new Price(10.00m);
            sut.Equals(sut2).Should().BeTrue();
        }

        [Test]
        public void Different_Prices_Are_NOT_Equal()
        {
            var sut = new Price(10.00m);
            var sut2 = new Price(5.00m);
            sut.Equals(sut2).Should().BeFalse();
        }
    }
}
