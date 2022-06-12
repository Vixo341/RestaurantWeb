using AutoMapper;
using Restaurant.Services.ProductAPI.Models;

namespace Restaurant.Services.ProductAPI
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMap()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<ProductDTO, Product>().ReverseMap();
            });

            return mappingConfig;
        }
    }
}
