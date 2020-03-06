using HashProduct.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace HashProduct.Domain.Acls
{
    public class AclDiscount : IAclDiscount
    {
        public int GetDiscountByProduct(int productId, int? userId)
        {
            int discount = 0;

            return discount;
        }
    }
}
