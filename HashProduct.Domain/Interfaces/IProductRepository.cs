using HashProduct.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace HashProduct.Domain.Interfaces
{
    public interface IProductRepository
    {
        IEnumerable<ProductEntity> GetAllProducts();
    }
}
