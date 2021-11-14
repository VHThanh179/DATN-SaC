using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Share.Common;
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
        [HttpGet]
        [Route("/api/paging")]
        public async Task<ActionResult<ProductDTO>> Get([FromQuery] PagingParameter productParameters)
        {
            var prodObj = new ProductDTO();
            var products = await _productSvc.GetPagingProducts(productParameters);
            prodObj.Products = products;
            prodObj.TotalCount = products.TotalCount;
            return Ok(prodObj); 
        }
        // GET api/GetProduct/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> GetProduct(int id)
        {
            return await _productSvc.GetProductAsync(id);
        }
    }
}