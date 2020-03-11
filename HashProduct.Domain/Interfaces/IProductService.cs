using HashProduct.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HashProduct.Domain.Interfaces
{
    public interface IProductService
    {
        Task<IEnumerable<Product>> GetAllProductsWithDiscount(string userId);
    }
}
