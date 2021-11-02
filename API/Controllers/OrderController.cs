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
    public class OrderController : ControllerBase
    {
        private readonly IOrderSvc _orderSvc;
        public OrderController(IOrderSvc orderSvc)
        {
            _orderSvc = orderSvc;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Order>>> GetOrderbyCustomer([FromQuery] int id)
        {
            var listOrder = await _orderSvc.GetOrderByCustomerAsync(id);
            return listOrder;
        }
    }
}