using HashProduct.Domain.Acls;
using HashProduct.Domain.Contexts;
using HashProduct.Domain.Interfaces;
using HashProduct.Domain.Repositories;
using HashProduct.Domain.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using AutoMapper;
using System;
using HashProduct.Domain.Models.Profiles;
using HashProduct.Domain.Models;

namespace HashProduct.Domain
{
    public static class DependencyInjectionExtensions
    {
        public static IServiceCollection ConfigureDomainDependencies(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<IProductService, ProductService>();
            var discountConfig = configuration.GetSection("DiscountServiceConfig")?.Get<DiscountServicesConfig>();
            services.AddTransient<IAclDiscount>(s => new AclDiscount(discountConfig.Host, discountConfig.Port));
            services.AddEntityFrameworkNpgsql()
             .AddDbContext<ProductContext>(options => options.UseNpgsql(configuration.GetSection("HashCnnString").Value));
            
            var mappingConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new ProductsProfile());
            });

            IMapper mapper = mappingConfig.CreateMapper();
            services.AddSingleton(mapper);

            AppContext.SetSwitch("System.Net.Http.SocketsHttpHandler.Http2UnencryptedSupport", true);

            return services;
        }
    }
}
