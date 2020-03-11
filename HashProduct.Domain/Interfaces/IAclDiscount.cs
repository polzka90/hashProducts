using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HashProduct.Domain.Interfaces
{
    public interface IAclDiscount
    {
        Task<float> GetDiscountByProductAsync(string productId, string userId);
    }
}
