﻿using AutoMapper;
using NLayer.Core.DTOs;
using NLayer.Core.DTOs.Product;
using NLayer.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Service.Mapping
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<Product, ProductDto>().ReverseMap();
            CreateMap<Category, CategoryDto>().ReverseMap();
            CreateMap<ProductFeature, ProductFeatureDto>().ReverseMap();
            CreateMap<UpdatedProductDto, Product>().ReverseMap();
            CreateMap<CreateProductDto, Product>().ReverseMap();
            CreateMap<Product,ProductCategoryDto>().ReverseMap();
        }
        //opt.MapFrom(src=>src.Price!=default ? src.Price : dest.Price)
    }
}
