using Microsoft.EntityFrameworkCore;
using Share.Interfaces;
using Share.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Share.Services
{
    public class OrderSvc : IOrderSvc
    {
        protected DataContext _context;
        public OrderSvc(DataContext context)
        {
            _context = context;
        }
        public async Task<List<Order>> GetAllOrderAsync() 
        {
            List<Order> orders = new List<Order>();
            return orders = await _context.Orders.OrderByDescending(o => o.OrderDate)
                .Include(c => c.Customer)
                .Include(o => o.OrderDetails)
                .ToListAsync();
        }
        public async Task<List<Order>> GetOrderByCustomerAsync(int CustomerId)
        {
            List<Order> ordersByCus = new List<Order>();
            return ordersByCus = await _context.Orders.Where(c => c.CustomerId == CustomerId).OrderByDescending(o => o.OrderDate)
                .Include(c => c.Customer)
                .Include(o => o.OrderDetails)
                .ToListAsync();
        }
        public async Task<Order> GetOrderAsync(int id)
        {
            Order order = null;
            return order = await _context.Orders.Where(o => o.OrderId == id)
                .Include(c => c.Customer)
                .Include(o => o.OrderDetails).ThenInclude(p => p.Product)
                .FirstOrDefaultAsync();
        }
        public async Task<int> AddOrderAsync(Order order)
        {
            int ret = 0;
            try
            {
                await _context.Orders.AddAsync(order);
                await _context.SaveChangesAsync();
                ret = order.OrderId;
            }
            catch
            {
                ret = 0;
            }
            return ret;
        }
        public async Task<int> EditOrderAsync(int id, Order order)
        {
            int ret = 0;
            try
            {
                _context.Orders.Update(order);
                await _context.SaveChangesAsync();
                ret = order.OrderId;
            }
            catch
            {
                ret = 0;
            }
            return ret;
        }

        //sync 

        public List<Order> GetAllOrder()
        {
            List<Order> orders = new List<Order>();
            return orders = _context.Orders.OrderByDescending(o => o.OrderDate)
                .Include(c => c.Customer)
                .Include(o => o.OrderDetails)
                .ToList();
        }

        public List<Order> GetOrderByCustomer(int CustomerId)
        {
            List<Order> orders = new List<Order>();
            return orders = _context.Orders.Where(o => o.CustomerId == CustomerId).OrderByDescending(o => o.OrderDate)
                .Include(c => c.Customer)
                .Include(o => o.OrderDetails)
                .ToList();
        }

        public Order GetOrder(int id)
        {
            Order order = null;
            return order = _context.Orders.Where(o => o.OrderId == id)
                .Include(c => c.Customer)
                .Include(o => o.OrderDetails).ThenInclude(p => p.Product)
                .FirstOrDefault();
        }

        public int AddOrder(Order order)
        {
            int ret = 0;
            try
            {
                _context.Add(order);
                _context.SaveChanges();
                ret = order.OrderId;
            }
            catch
            {
                ret = 0;
            }
            return ret;
        }

        public int EditOrder(int id, Order order)
        {
            int ret = 0;
            try
            {
                _context.Update(order);
                _context.SaveChanges();
                ret = order.OrderId;

            }
            catch
            {
                ret = 0;
            }
            return ret;
        }
    }
}
