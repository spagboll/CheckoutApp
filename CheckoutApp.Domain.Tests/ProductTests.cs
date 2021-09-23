using CheckoutApp.Domain.Products;
using FluentAssertions;
using NUnit.Framework;
using System;

namespace CheckoutApp.Domain.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Can_Create_Product()
        {
            var sut = new Product("sku"); 
            sut.Should().NotBeNull();
        }

        [Test]
        public void Can_Get_Sku()
        {
            var sut = new Product("sku");
            sut.Sku.Should().BeEquivalentTo("sku");
        }

        [Test]
        public void SKU_Should_Not_Be_Null()
        {
            Action act = () => new Product(null);
            
            act.Should().Throw<ArgumentNullException>()
                .And.ParamName.Should().Be("sku");
        }
    }
}