using Microsoft.EntityFrameworkCore;
using Share.Interfaces;
using Share.Models;
using Share.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Share.Services
{
    public class UserSvc : IUserSvc
    {
        protected DataContext _context;
        protected IEncodeHelper _encodeHelper;
        public UserSvc(DataContext context, IEncodeHelper encodeHelper)
        {
            _context = context;
            _encodeHelper = encodeHelper;
        }

        public async Task<List<User>> GetAllUserAsync()
        {
            List<User> list =  await _context.Users.ToListAsync();
            return list;
        }

        public async Task<User> GetUserAsync(int id)
        {
            User user = null;
            user = await _context.Users.FindAsync(id);
            return user;
        }

        public async Task<int> AddUserAsync(User user)
        {
            int ret = 0;
            try
            {
                user.Status = true;
                user.Password = _encodeHelper.Encode(user.Password);
                await _context.AddAsync(user);
                await _context.SaveChangesAsync();
                ret = user.UserId;
            }
            catch
            {
                ret = 0;
            }
            return ret;
        }

        public async Task<int> EditUserAsync(int id, User user)
        {
            int ret = 0;
            try
            {
                User _user = null;
                _user = _context.Users.Find(id); //cách này chỉ dùng cho Khóa chính

                _user.UserName = user.UserName;
                _user.FullName = user.FullName;
                _user.Email = user.Email;
                _user.DoB = user.DoB;
                _user.Roles = user.Roles;
                _user.Status = user.Status;
                if (user.Password != null && user.Password != string.Empty)
                {
                    if (_user.Password == user.Password)
                    {
                        _user.Password = user.Password;
                        _user.ConfirmPass = user.Password;
                    }
                    else
                    {
                        user.Password = _encodeHelper.Encode(user.Password);
                        _user.Password = user.Password;
                        _user.ConfirmPass = user.Password;
                    }
                }
                _context.Update(_user);
                await _context.SaveChangesAsync();
                ret = user.UserId;
            }
            catch
            {
                ret = 0;
            }
            return ret;
        }

        public async Task<User> LoginAsync(ViewLogin login)
        {
            var acc = await _context.Users.Where(
                u => u.UserName.Equals(login.UserName)
                && u.Password.Equals(_encodeHelper.Encode(login.Password))
                ).FirstOrDefaultAsync();
            return acc;
        }
               

        //sync 

        public List<User> GetAllUser()
        {
            List<User> list = _context.Users.ToList();
            return list;
        }

        public User GetUser(int id)
        {
            User user = null;
            user = _context.Users.Find(id);
            user.ConfirmPass = user.Password;
            return user;
        }

        public int AddUser(User user)
        {
            int ret = 0;
            try
            {
                user.Status = true;
                user.Password = _encodeHelper.Encode(user.Password);
                _context.Add(user);
                _context.SaveChanges();
                ret = user.UserId;
            }
            catch
            {
                ret = 0;
            }
            return ret;
        }

        public int EditUser(int id, User user)
        {
            int ret = 0;
            try
            {
                _context.Update(user);
                _context.SaveChanges();
                ret = user.UserId;

            }
            catch
            {
                ret = 0;
            }
            return ret;
        }

        public User Login(ViewLogin login)
        {
            var acc = _context.Users.Where(
               u => u.UserName.Equals(login.UserName)
               && u.Password.Equals(_encodeHelper.Encode(login.Password))
               ).FirstOrDefault();
            return acc;
        }
    }
}
