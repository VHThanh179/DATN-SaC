﻿using Share.Models;
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
        //async
        Task<List<Customer>> GetAllCustomerAsync();
        Task<Customer> GetCustomerAsync(int id);
        Task<Customer> GetCustomerbyEmailAsync(string email);
        Task<int> AddCustomerAsync(Customer customer);
        Task<int> EditCustomerAsync(int id, Customer customer);
        Task<Customer> LoginAsync(ViewWebLogin login);
        Task<bool> CheckEmail(string email);
        Task<bool> CheckPhoneNumber(string phoneNumber);

        //sync 
        List<Customer> GetAllCustomer();
        Customer GetCustomer(int id);
        int EditCustomer(int id, Customer customer);
    }
}
