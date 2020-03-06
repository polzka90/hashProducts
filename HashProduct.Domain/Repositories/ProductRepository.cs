using HashProduct.Domain.Entities;
using HashProduct.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace HashProduct.Domain.Repositories
{
    public class ProductRepository : IProductRepository
    {
        public IEnumerable<ProductEntity> GetAllProducts()
        {
            List<ProductEntity> list = new List<ProductEntity>();

            return list;
        }
    }
}
