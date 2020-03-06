using HashProduct.Domain.Interfaces;;
using HashProduct.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace HashProduct.Domain.Services
{
    public class ProductService : IProductService
    {
        public IEnumerable<Product> GetAllProductsWithDiscount(int? userId)
        {
            List<Product> list = new List<Product>();

            return list;
        }
    }
}
