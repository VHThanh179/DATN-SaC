using Share.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Share.Interfaces
{
    public interface IOrderDetails
    {
        Task<List<OrderDetails>> GetOrderDetailsByOrderAsync(int orderId);
        Task<int> AddOrderDetailsAsync(OrderDetails orderDetails);
    }
}
