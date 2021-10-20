using Share.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Share.Interfaces
{
    public interface IOrderSvc
    {
        //async
        Task<List<Order>> GetAllOrderAsync();
        Task<List<Order>> GetOrderByCustomerAsync(int CustomerId);
        Task<Order> GetOrderAsync(int id);
        Task<int> AddOrderAsync(Order order);
        Task<int> EditOrderAsync(int id, Order order);

        //sync
        List<Order> GetAllOrder();
        List<Order> GetOrderByCustomer(int CustomerId);
        Order GetOrder(int id);
        int AddOrder(Order order);
        int EditOrder(int id, Order order);
    }
}
