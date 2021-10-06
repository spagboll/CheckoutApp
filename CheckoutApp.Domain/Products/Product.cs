using System;

namespace CheckoutApp.Domain.Products
{
    public class Product
    {
        private Product(string sku)
        {
            Sku = sku ?? throw new ArgumentNullException(nameof(sku));
        }

        public static Product Create(string sku)
        {
            var newProduct = new Product(sku);
            newProduct.Id = Guid.NewGuid();
            return newProduct;
        }

        public string Sku { get; }

        public Guid Id { get; private set; }
        

    }
}