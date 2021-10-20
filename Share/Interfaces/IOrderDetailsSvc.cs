using Share.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Share.Interfaces
{
    public interface IOrderDetailsSvc
    {
        Task<List<OrderDetails>> GetOrderDetailsByOrderAsync(int orderId);
        Task<int> AddOrderDetailsAsync(OrderDetails orderDetails);

        //sync
        List<OrderDetails> GetOrderDetailsByOrder(int orderid);
        int AddOrderDetails(OrderDetails orderDetails);
    }
}
