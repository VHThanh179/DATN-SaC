using Share.Models;
using Share.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Share.Interfaces
{
    public interface ICustomerSvc
    {
        Task<List<Customer>> GetAllCustomerAsync();
        Task<Customer> GetCustomerAsync(int id);
        Task<int> AddCustomerAsync(Customer customer);
        Task<int> EditCustomerAsync(int id, Customer customer);
        Task<Customer> LoginAsync(ViewWebLogin login);
    }
}
