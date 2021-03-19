using System.Collections.Generic;
using System.Linq;
using Dapper;
using Microsoft.Extensions.Options;
using SimpleShop.Core.Config;
using SimpleShop.Data.Models;

namespace SimpleShop.Data
{
    public class ProductRepository : BaseRepository, IProductRepository
    {
        public ProductRepository(IOptions<AppSettingsConfig> options) : base(options)
        {
        }

        public int AddProduct(ProductDto product)
        {
            var result = _connection.QuerySingle<int>("dbo.Product_Add",
                new
                {
                    name = product.Name,
                    categoryId = product.Category.Id,
                    brandId = product.Brand.Id,
                    price = product.Price,
                    width = product.Width,
                    height = product.Height,
                    length = product.Length,
                    weight = product.Weight,
                    powerConsumprion = product.PowerConsumption
                },
                commandType: System.Data.CommandType.StoredProcedure
            );
            return result;
        }

        public List<ProductDto> GetProducts()
        {
            var result = _connection.Query<ProductDto, BrandDto, CategoryDto, ProductDto>(
                        "dbo.Product_SelectAll",
                        (product, brand, category) =>
                        {
                            product.Brand = brand;
                            product.Category = category;
                            return product;
                        },
                        splitOn: "Id")
                    .Distinct()
                    .ToList();
            return result;
        }

    }


}