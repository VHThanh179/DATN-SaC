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
using API.Hubs;
using Microsoft.AspNetCore.SignalR;

namespace API.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class CartController : ControllerBase
    {
        private readonly IOrderSvc _orderSvc;
        private readonly IOrderDetailsSvc _orderDetailsSvc;
        private readonly IShipInfoSvc _shipInfoSvc;
        private readonly IVoucherSvc _voucherSvc;
        private readonly IHubContext<NotiHub> _hubContext;

        public CartController(IOrderDetailsSvc orderDetailsSvc, IOrderSvc orderSvc, IShipInfoSvc shipInfoSvc, IVoucherSvc voucherSvc, 
            IHubContext<NotiHub> hubContext)
        {
            _hubContext = hubContext;
            _orderDetailsSvc = orderDetailsSvc;
            _orderSvc = orderSvc;
            _shipInfoSvc = shipInfoSvc;
            _voucherSvc = voucherSvc;
        }

        [HttpPost]
        public async Task<ActionResult<int>> PostCart(APICart content)
        {
            Cart cart = content.cart;
            ShipInfo shipInfo = content.shipInfo;
            string vouCode = content.voucherCode;
            try
            {
                var order = new Order()
                {
                    OrderStatus = OrderStatus.CurOrder,
                    CustomerId = cart.CustomerId,
                    Total = cart.Total,
                    OrderDate = DateTime.Now,
                    Notes = shipInfo.Notes
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
                        Notes = order.Notes
                    };
                    await _orderDetailsSvc.AddOrderDetailsAsync(details);
                }

                shipInfo.OrderId = orderId;
                await _shipInfoSvc.AddShipInfoAsync(shipInfo);
                Voucher voucher = await _voucherSvc.GetVoucherByCodeAsync(vouCode);
                if (voucher != null)
                {
                    voucher.VoucherQuantity--;
                    await _voucherSvc.EditVoucherAsync(voucher);
                }
            }
            catch
            {
                return BadRequest(-1);
            }
            return Ok(1);
        }

        [Route("/api/NewNoti")]
        [HttpPost]
        public async Task<ActionResult> NotiContent([FromBody] Notifi notifi)
        {
            await _hubContext.Clients.All.SendAsync("Notification", notifi.Content);
            return Ok("Notification has been sent successfully!");
        }
    }
}
