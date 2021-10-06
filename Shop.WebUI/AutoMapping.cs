using AutoMapper;
using Shop.Entities;
using Shop.WebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.WebUI
{
    public class AutoMapping : Profile
    {
        public AutoMapping()
        {

            CreateMap<Product, ProductCreateModel>()
                .ForMember(dest => dest.SelectedCategoryId, opt =>
                {
                    opt.MapFrom(src => src.CategoryId);
                });

            CreateMap<ProductCreateModel, Product>()
                .ForMember(dest => dest.CategoryId, opt =>
                {
                    opt.MapFrom(src => src.SelectedCategoryId);
                });
        }

    }
}
