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
            var fixture = new TestFixture();
            var sut = fixture.BuildSut();
            sut.Should().NotBeNull();
        }

        [Test]
        public void Can_Get_Sku()
        {
            var sut = new TestFixture()
                .WithSku("cheese")
                .BuildSut();
            
            sut.Sku.Should().BeEquivalentTo("cheese");
        }

        [Test]
        public void SKU_Should_Not_Be_Null()
        {
            var fixture = new TestFixture()
                .WithSku(null);

            Action act = () => fixture.BuildSut();
            
            act.Should().Throw<ArgumentNullException>()
                .And.ParamName.Should().Be("sku");
        }

        private class TestFixture
        {
            public TestFixture()
            {
                this.Sku = Guid.NewGuid().ToString();
            }

            public string Sku { get; set; }

            public Product BuildSut()
            {
                return Product.Create(this.Sku);
            }

            public TestFixture WithSku(string sku)
            {
                this.Sku = sku;
                return this;
            }
        }
    }
}