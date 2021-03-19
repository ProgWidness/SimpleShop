using System.Collections.Generic;
using SimpleShop.Data.Models;

namespace SimpleShop.Data
{
    public interface IProductRepository
    {
        int AddProduct(ProductDto product);
        List<ProductDto> GetProducts();
    }
}