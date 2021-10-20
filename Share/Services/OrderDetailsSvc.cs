using Microsoft.EntityFrameworkCore;
using Share.Interfaces;
using Share.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Share.Services
{
    public class OrderDetailsSvc : IOrderDetailsSvc
    {
        protected DataContext _context;
        public OrderDetailsSvc(DataContext context)
        {
            _context = context;
        }
        public async Task<List<OrderDetails>> GetOrderDetailsByOrderAsync(int orderId)
        {
            return await _context.OrderDetails.Where(o => o.OrderId == orderId).ToListAsync();
        }
        public async Task<int> AddOrderDetailsAsync(OrderDetails orderDetails)
        {
            int ret = 0;
            try
            {
                await _context.OrderDetails.AddAsync(orderDetails);
                await _context.SaveChangesAsync();
                ret = orderDetails.OrderId;
            }
            catch
            {
                ret = 0;
            }
            return ret;
        }

        //sync 
        public List<OrderDetails> GetOrderDetailsByOrder(int orderid)
        {
            return _context.OrderDetails.Where(o => o.OrderId == orderid).ToList();
        }

        public int AddOrderDetails(OrderDetails orderDetails)
        {
            int ret = 0;
            try
            {
                _context.OrderDetails.Add(orderDetails);
                _context.SaveChanges();
                ret = orderDetails.OrderId;
            }
            catch
            {
                ret = 0;
            }
            return ret;
        }
    }
}
