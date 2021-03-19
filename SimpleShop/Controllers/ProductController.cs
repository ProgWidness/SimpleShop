using System.Collections.Generic;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SimpleShop.Buisness;
using SimpleShop.Data.Models;
using SimpleShop.Models.OutputModels;

namespace SimpleShop.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        private IProductService _service;
        private IMapper _mapper;
        public ProductController(IMapper mapper, IProductService service)
        {
            _mapper = mapper;
            _service = service;
        }

        [HttpGet]
        public ActionResult<List<ProductDto>> GetProduct()
        {
            var products = _service.GetProducts();
            var result = _mapper.Map<List<ProductOutputModel>>(products);
            return Ok(result);
        }
    }
}