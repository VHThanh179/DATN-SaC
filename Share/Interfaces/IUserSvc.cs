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
        //async
        Task<List<User>> GetAllUserAsync();
        Task<User> GetUserAsync(int id);
        Task<int> AddUserAsync(User user);
        Task<int> EditUserAsync(int id, User user);
        Task<User> LoginAsync(ViewLogin login);

        //sync
        List<User> GetAllUser();
        User GetUser(int id);
        int AddUser(User user);
        int EditUser(int id, User user);
        User Login(ViewLogin viewLogin);
        User GetUserbyMail(string email);
        int EditUserbyMail(int id, User user);
        bool CheckEmail(string email);
    }
}
