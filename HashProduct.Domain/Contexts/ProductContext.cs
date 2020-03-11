using HashProduct.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace HashProduct.Domain.Contexts
{
    public class ProductContext : DbContext
    {
        public DbSet<ProductEntity> Products { get; set; }

        public ProductContext(DbContextOptions<ProductContext> options) :
            base(options)
        {
        }
    }
}
