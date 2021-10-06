using Share.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Share.Interfaces
{
    public interface IOrderSvc
    {
        Task<List<Order>> GetOrderAllAsync();
        Task<List<Order>> GetOrderByCustomerAsync(int CustomerId);
        Task<Order> GetOrderAsync(int id);
        Task<int> AddOrderAsync(Order order);
        Task<int> EditOrderAsync(int id, Order order);
    }
}
