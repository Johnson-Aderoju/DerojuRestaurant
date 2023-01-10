using System;
using AutoMapper;
using DerojuRez.Models;
using DerojuRez.Services.ProductAPI.Model;
using DerojuRez.Services.ProductAPI.Model.Dtos;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DerojuRez.Services.ProductAPI
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<ProductDto, Product>();
                config.CreateMap<Product, ProductDto>();

            });

            return mappingConfig;
        }
    }
}