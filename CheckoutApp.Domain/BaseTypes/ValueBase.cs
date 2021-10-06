using System;
using System.Collections.Generic;
using System.Linq;

namespace CheckoutApp.Domain.BaseTypes
{
    public abstract class ValueBase<T> : IEquatable<T>
        where T : ValueBase<T>
    {
        public bool Equals(T? other)
        {
            if (other == null)
            {
                return false;
            }

            if (GetType() != other.GetType())
            {
                return false;
            }

            var valueObj = (T)other;

            return GetEqualityComponents().SequenceEqual(valueObj.GetEqualityComponents());
        }

        protected abstract IEnumerable<object> GetEqualityComponents();

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            int hashCode = 0;
            foreach (var item in this.GetEqualityComponents())
            {
                hashCode = HashCode.Combine(hashCode, item.GetHashCode());
            }

            return hashCode;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
