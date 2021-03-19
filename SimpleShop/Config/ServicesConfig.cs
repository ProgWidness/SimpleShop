using Microsoft.Extensions.DependencyInjection;
using SimpleShop.Data;

namespace SimpleShop.Config
{
    public static class ServicesConfig
    {
        public static void RegistrateServicesConfig(this IServiceCollection services)
        {
            services.AddScoped<IProductRepository, ProductRepository>();
        }
    }
}