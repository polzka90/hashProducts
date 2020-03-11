using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HashProduct.Domain.Interfaces;
using HashProduct.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace HashProducts.Api.Controllers
{
    [Route("[controller]")]
    public class ProductController : Controller
    {
        private IProductService _productService;
        public ProductController(IProductService productService)
        {
            this._productService = productService;
        }

        [HttpGet]
        public async Task<IEnumerable<Product>> Index()
        {
            string userId = Request?.Headers["X-USER-ID"];

            List<Product> products = (await _productService.GetAllProductsWithDiscount(userId)).ToList();

            return products;
        }
    }
}