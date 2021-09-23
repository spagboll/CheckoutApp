using CheckoutApp.Domain.BaseTypes;
using System;
using System.Collections.Generic;

namespace CheckoutApp.Domain.Products
{
    public class Price : ValueBase<Price>
    {
        private readonly decimal _price;

        public Price(decimal price)
        {
            if (price < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(price));
            }

            _price = price;
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {            
            yield return _price;
        }
    }
}
