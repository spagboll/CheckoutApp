using System.Collections.Generic;
using System.Threading.Tasks;
using CheckoutApp.Domain.Products;

namespace CheckoutApp.Domain.Repository
{
    public interface IProductRepository
    {
        Task<Product> GetBySku(string sku);
        Task<IEnumerable<Product>> GetProducts();
    }
}