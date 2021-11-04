using CheckoutApp.Domain.Products;
using CheckoutApp.Domain.Repository;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CheckoutApp.Application.Queries
{
    public class GetProductBySkuQueryHandler : IRequestHandler<GetProductBySkuQuery, Product>
    {
        private readonly IProductRepository _productRepository;

        public GetProductBySkuQueryHandler(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public Task<Product> Handle(GetProductBySkuQuery request, CancellationToken cancellationToken)
        {
            return _productRepository.GetBySku(request.Sku);
        }
    }
}
