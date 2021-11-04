using CheckoutApp.Domain.Products;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace CheckoutApp.Application.Queries
{
    public class GetProductBySkuQuery : IRequest<Product>
    {
        public string Sku { get; private set; }

        public GetProductBySkuQuery(string sku)
        {
           Sku = sku;
        }
    }
}
