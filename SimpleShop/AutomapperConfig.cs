using AutoMapper;
using SimpleShop.Data.Models;
using SimpleShop.Models.OutputModels;

namespace SimpleShop
{
    public class AutomapperConfig : Profile
    {
        public AutomapperConfig()
        {
            CreateMap<ProductDto, ProductOutputModel>();
            CreateMap<CategoryDto, CategoryOutpuModel>();
            CreateMap<BrandDto, BrandOutputModel>();
        }

    }
}