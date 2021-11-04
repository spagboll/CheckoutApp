using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using CheckoutApp.Domain.Products;
using CheckoutApp.Domain.Repository;
using MediatR;

namespace CheckoutApp.Application.Queries
{
    public class GetProductsQueryHandler : IRequestHandler<GetProductsQuery, IEnumerable<Product>>
    {
        private readonly IProductRepository _productRepository;

        public GetProductsQueryHandler(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public Task<IEnumerable<Product>> Handle(GetProductsQuery request, CancellationToken cancellationToken)
        {
            return _productRepository.GetProducts();
        }
    }
}