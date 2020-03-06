using HashProduct.Domain.Acls;
using HashProduct.Domain.Interfaces;
using HashProduct.Domain.Repositories;
using HashProduct.Domain.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace HashProduct.Domain
{
    public static class DependencyInjectionExtensions
    {
        public static IServiceCollection ConfigureDomainDependencies(this IServiceCollection services)
        {
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<IAclDiscount, AclDiscount>();

            return services;
        }
    }
}
