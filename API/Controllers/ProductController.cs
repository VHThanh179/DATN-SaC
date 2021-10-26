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
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductSvc _productSvc;
        public ProductController(IProductSvc productSvc)
        {
            _productSvc = productSvc;
        }
        // GET: api/GetAllProduct
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Product>>> GetAllProduct()
        {
            return await _productSvc.GetAllProductAsync();
        }

        // GET api/GetProduct/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> GetProduct(int id)
        {
            return await _productSvc.GetProductAsync(id);
        }
    }
}