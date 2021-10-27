using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Share.Models;
using Share.Interfaces;
using Share.Models.ViewModels;

namespace API.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class CartController : ControllerBase
    {
        private readonly IOrderSvc _orderSvc;
        private readonly IOrderDetailsSvc _orderDetailsSvc;

        public CartController(IOrderDetailsSvc orderDetailsSvc, IOrderSvc orderSvc)
        {
            _orderDetailsSvc = orderDetailsSvc;
            _orderSvc = orderSvc;
        }

        [HttpPost]
        public async Task<ActionResult<int>> PostCart(Cart cart)
        {
            try
            {
                var order = new Order()
                {
                    OrderStatus = OrderStatus.CurOrder,
                    CustomerId = cart.CustomerId,
                    Total = cart.Total,
                    OrderDate = DateTime.Now,
                    Notes = ""
                };

                int orderId = await _orderSvc.AddOrderAsync(order);
                order.OrderId = orderId;

                List<CartItem> dataCart = cart.ListViewCart;
                for (int i = 0; i < dataCart.Count; i++)
                {
                    OrderDetails details = new OrderDetails()
                    {
                        OrderId = orderId,
                        ProductId = dataCart[i].product.ProductId,
                        Quantity = dataCart[i].Quantity,
                        TotalAmount = dataCart[i].product.Price * dataCart[i].Quantity,
                        Notes = ""
                    };
                    await _orderDetailsSvc.AddOrderDetailsAsync(details);
                }
            }
            catch
            {
                return BadRequest(-1);
            }
            return Ok(1);
        }
    }
}
