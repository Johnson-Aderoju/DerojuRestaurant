using System;
using AutoMapper;
using DerojuRez.Services.ProductAPI.Models;
using DerojuRez.Services.ProductAPI.Models.Dtos;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DerojuRez.Services.ProductAPI
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMap()
        {
            var mappingConfig = new MapperConfiguration(MappingConfig =>
            {
                config.CreateMap<ProductDto, Product>().Reverse();

            });

            return mappingConfig;
        }
    }
}