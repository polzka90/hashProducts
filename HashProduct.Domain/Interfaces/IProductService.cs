using HashProduct.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace HashProduct.Domain.Interfaces
{
    public interface IProductService
    {
        IEnumerable<Product> GetAllProductsWithDiscount(int? userId);
    }
}
