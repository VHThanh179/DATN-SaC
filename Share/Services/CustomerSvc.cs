﻿using Microsoft.EntityFrameworkCore;
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
    public class CustomerSvc : ICustomerSvc
    {
        protected DataContext _context;
        protected IEncodeHelper _encodeHelper;
        public CustomerSvc(DataContext context, IEncodeHelper encodeHelper)
        {
            _context = context;
            _encodeHelper = encodeHelper;
        }

        public async Task<List<Customer>> GetAllCustomerAsync()
        {
            List<Customer> list = await _context.Customers.ToListAsync();
            return list;
        }

        public async Task<Customer> GetCustomerAsync(int id)
        {
            Customer customer = null;
            customer = await _context.Customers.FindAsync(id);
            customer.ConfirmPassword = customer.Password;
            return customer;
        }

        public async Task<Customer> GetCustomerbyEmailAsync(string email)
        {
            Customer customer = null;
            customer = await _context.Customers.Where(e => e.Email == email).FirstOrDefaultAsync();
            return customer;
        }

        public async Task<int> AddCustomerAsync(Customer customer)
        {
            int ret = 0;
            try
            {
                customer.Status = true;
                customer.CreatedDate = DateTime.Now;
                customer.Password = _encodeHelper.Encode(customer.Password);
                await _context.AddAsync(customer);
                await _context.SaveChangesAsync();
                ret = customer.CustomerId;
            }
            catch
            {
                ret = 0;
            }
            return ret;
        }

        public async Task<int> EditCustomerAsync(int id, Customer customer)
        {
            int ret = 0;
            try
            {
                Customer _cus = null;
                _cus = _context.Customers.Find(id);

                _cus.Email = customer.Email;
                _cus.FullName = customer.FullName;
                _cus.DoB = customer.DoB;
                _cus.Address = customer.Address;
                _cus.PhoneNumber = customer.PhoneNumber;
                if (customer.Password != null && customer.Password != string.Empty)
                {
                    if (_cus.Password == customer.Password)
                    {
                        _cus.Password = customer.Password;
                        _cus.ConfirmPassword = customer.ConfirmPassword;
                    }
                    else
                    {
                        customer.Password = _encodeHelper.Encode(customer.Password);
                        _cus.Password = customer.Password;
                        _cus.ConfirmPassword = customer.Password;
                    }
                }

                _context.Update(_cus);
                await _context.SaveChangesAsync();
                ret = customer.CustomerId;
            }
            catch
            {
                ret = 0;
            }
            return ret;

        }

        public async Task<Customer> LoginAsync(ViewWebLogin viewWebLogin)
        {
            var acc = await _context.Customers.Where(c => c.Email.Equals(viewWebLogin.Email)
                    && c.Password.Equals(_encodeHelper.Encode(viewWebLogin.Password))
                    ).FirstOrDefaultAsync();
            return acc;
        }

        public async Task<bool> CheckEmail(string email)
        {
            Customer customer = new Customer();
            customer = await _context.Customers.Where(e => e.Email == email).FirstOrDefaultAsync();
            if (customer != null)
            {
                return true;
            }
            return false;
        }

        public async Task<bool> CheckPhoneNumber(string phoneNumber)
        {
            Customer customer = new Customer();
            customer = await _context.Customers.Where(e => e.PhoneNumber == phoneNumber).FirstOrDefaultAsync();
            if (customer != null)
            {
                return true;
            }
            return false;
        }

        //sync
        public List<Customer> GetAllCustomer()
        {
            return _context.Customers.ToList();
        }

        public Customer GetCustomer(int id)
        {
            Customer customer = null;
            customer = _context.Customers.Find(id);
            customer.ConfirmPassword = customer.Password;
            return customer;
        }

        public int EditCustomer(int id, Customer customer)
        {
            int ret = 0;
            try
            {
                _context.Update(customer);
                _context.SaveChanges();
                ret = customer.CustomerId;
            }
            catch
            {
                ret = 0;
            }
            return ret;
        }
    }
}
