using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using SimpleShop.Data;
using SimpleShop.Data.Models;

namespace SimpleShop.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {

        public ProductController()
        {

        }

        [HttpGet]
        public ActionResult<List<ProductDto>> GetProduct()
        {

        }
    }
}