using System.Collections.Generic;
using SimpleShop.Data.Models;

namespace SimpleShop.Buisness
{
    public interface IProductService
    {
        List<ProductDto> GetProducts();
    }
}