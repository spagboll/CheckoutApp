using System.Collections.Generic;
using CheckoutApp.Domain.Products;
using MediatR;

namespace CheckoutApp.Application.Queries
{
    public class GetProductsQuery : IRequest<IEnumerable<Product>>
    {
    }
}