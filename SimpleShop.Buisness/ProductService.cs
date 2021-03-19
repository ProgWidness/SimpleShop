using System.Collections.Generic;
using SimpleShop.Data;
using SimpleShop.Data.Models;

namespace SimpleShop.Buisness
{
    public class ProductService : IProductService
    {
        private IProductRepository _repository;
        public ProductService(IProductRepository repository)
        {
            _repository = repository;
        }

        public List<ProductDto> GetProducts()
        {
            return _repository.GetProducts();
        }

    }
}