using System;
using System.Collections.Generic;
using System.Text;

namespace HashProduct.Domain.Interfaces
{
    public interface IAclDiscount
    {
        int GetDiscountByProduct(int productId, int? userId);
    }
}
