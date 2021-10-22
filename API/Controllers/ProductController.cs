using Microsoft.AspNetCore.Mvc;
using Share.Interfaces;
using Share.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API.Controllers
{
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductSvc _productSvc;
        public ProductController(IProductSvc productSvc)
        {
            _productSvc = productSvc;
        }
        // GET: api/GetAllProduct
        [Route("api/[controller]")]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Product>>> GetAllProduct()
        {
            return await _productSvc.GetAllProductAsync();
        }

        // GET api/GetProduct/5
        [Route("GetProduct")]
        [HttpGet]
        public async Task<ActionResult<Product>> GetProduct([FromQuery] int id)
        {
            return await _productSvc.GetProductAsync(id);
        }
    }
}