using HashProduct.Domain.Interfaces;
using HashProduct.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashProduct.Domain.Services
{
    public class ProductService : IProductService
    {
        private IProductRepository _productRepository;
        private IAclDiscount _aclDiscount;
        public ProductService(IProductRepository productRepository, IAclDiscount aclDiscount)
        {
            this._productRepository = productRepository;
            this._aclDiscount = aclDiscount;
        }
        public async Task<IEnumerable<Product>> GetAllProductsWithDiscount(string userId)
        {
            List<Product> list = new List<Product>();

            list = (await _productRepository.GetAllProducts()).ToList();

            foreach (var product in list)
            {
                float discount = await this._aclDiscount.GetDiscountByProductAsync(product.Id, userId);

                product.Discount = new Models.Discount() { Pct = discount, ValueInCents = discount > 0 ? ((product.PriceInCents * discount) / 100) : discount };
            }

            return list;
        }
    }
}
