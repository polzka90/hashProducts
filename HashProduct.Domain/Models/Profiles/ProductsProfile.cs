using AutoMapper;
using HashProduct.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace HashProduct.Domain.Models.Profiles
{
    public class ProductsProfile : Profile
    {
        public ProductsProfile()
        {
            CreateMap<Product, ProductEntity>().ForMember(dest => dest.price_in_cents, opt => opt.MapFrom(src => src.PriceInCents)).ReverseMap();
        }
        
    }
}
