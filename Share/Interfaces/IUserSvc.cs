using Share.Models;
using Share.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Share.Interfaces
{
    public interface IUserSvc
    {
        Task<List<User>> GetAllUserAsync();
        Task<User> GetUserAsync(int id);
        Task<int> AddUserAsync(User user);
        Task<int> EditUserAsync(int id, User user);
        Task<User> LoginAsync(ViewLogin login);
        public User Login(ViewLogin viewLogin);
    }
}
