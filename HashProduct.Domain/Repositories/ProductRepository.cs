using AutoMapper;
using HashProduct.Domain.Contexts;
using HashProduct.Domain.Entities;
using HashProduct.Domain.Interfaces;
using HashProduct.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HashProduct.Domain.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private ProductContext _productContext;
        private readonly IMapper _mapper;
        public ProductRepository(ProductContext productContext, IMapper mapper)
        {
            this._productContext = productContext;
            _mapper = mapper;
        }
        public async Task<IEnumerable<Product>> GetAllProducts()
        {
            List<ProductEntity> listEntity = new List<ProductEntity>();
            List<Product> listrsp = new List<Product>();
            listEntity = await _productContext.Products.ToListAsync();
            listrsp = _mapper.Map<List<Product>>(listEntity);

            return listrsp;
        }
    }
}
