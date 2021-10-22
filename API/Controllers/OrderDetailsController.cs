using Microsoft.AspNetCore.Authorization;
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
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class OrderDetailsController : ControllerBase
    {
        private readonly IOrderSvc _orderSvc;
        private readonly IOrderDetailsSvc _orderDetailsSvc;
        public OrderDetailsController(IOrderSvc orderSvc, IOrderDetailsSvc orderDetailsSvc)
        {
            _orderSvc = orderSvc;
            _orderDetailsSvc = orderDetailsSvc;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Order>>> GetOrder([FromQuery] int id)
        {
            var order = await _orderSvc.GetOrderAsync(id);
            List<Order> list = new List<Order>();
            list.Add(order);
            return list;
        }
    }
}