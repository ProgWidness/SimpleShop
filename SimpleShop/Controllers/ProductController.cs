using Microsoft.AspNetCore.Mvc;
using SimpleShop.Data;

namespace SimpleShop.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        private IProductRepository _repository;

        public ProductController(IProductRepository repository)
        {
            _repository = repository;
        }
    }
}