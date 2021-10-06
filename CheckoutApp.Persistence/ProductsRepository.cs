using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CheckoutApp.Domain.Products;
using CheckoutApp.Domain.Repository;


namespace CheckoutApp.Persistence
{
    public class ProductsRepository : IProductRepository
    {
        private IEnumerable<Product> _products { get; set; }

        public ProductsRepository()
        {
            _products = new List<Product>
            {
                Product.Create("BISCUIT"),
                Product.Create("CHEESE")
            };
        }
        
        public Task<Product> GetBySku(string sku)
        {
            return Task.Run(() => _products.FirstOrDefault(x => x.Sku == sku));
        }

        public Task<IEnumerable<Product>> GetProducts()
        {
            return Task.Run(() => _products);
        }
    }
}
