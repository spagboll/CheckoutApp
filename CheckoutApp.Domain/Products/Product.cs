using System;

namespace CheckoutApp.Domain.Products
{
    public class Product
    {
        public Product(string sku)
        {
            Sku = sku ?? throw new ArgumentNullException(nameof(sku));
        }

        public string Sku 
        {
            get; private set;    
        }

    }
}