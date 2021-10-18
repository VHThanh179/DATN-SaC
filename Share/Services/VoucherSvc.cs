using Microsoft.EntityFrameworkCore;
using Share.Interfaces;
using Share.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Share.Services
{
    public class VoucherSvc : IVoucherSvc
    {
        protected DataContext _context;
        public VoucherSvc(DataContext context)
        {
            _context = context;
        }
        public async Task<Voucher> GetVoucherAsync(int id)
        {
            var voucher = await _context.Vouchers.FindAsync(id);
            return voucher;
        }

        public async Task<List<Voucher>> GetVouchersAsync()
        {
            var list = await _context.Vouchers.ToListAsync();
            return list;
        }
        public async Task<int> AddVoucherAsync(Voucher voucher)
        {
            int value = 0;
            try
            {
                _context.Add(voucher);
                await _context.SaveChangesAsync();
                value = voucher.VoucherId;
            }
            catch (Exception){ value = 0; }
            return value;
        }

        public async Task<int> EditVoucherAsync(int id, Voucher voucher)
        {
            int value = 0;
            try
            {
                //Voucher _voucher = null;
                //_voucher = _context.Vouchers.Find(id);

                //_voucher.VoucherCode = voucher.VoucherCode;
                //_voucher.VoucherQuantity = voucher.VoucherQuantity;
                //_voucher.StartDate = voucher.StartDate;
                //_voucher.EndDate = voucher.EndDate;
                //_voucher.CategoryDiscount = voucher.CategoryDiscount;
                //_voucher.Value = voucher.Value;

                _context.Update(voucher);
                await _context.SaveChangesAsync();
                value = voucher.VoucherId;
            }
            catch (Exception){ value = 0; }
            return value;
        }
        public List<Voucher> GetAllVoucher()
        {
            var list = _context.Vouchers.ToList();
            return list;
        }

        public Voucher GetVoucher(int id)
        {
            var voucher = _context.Vouchers.Find(id);
            return voucher;
        }
        
        public int AddVoucher(Voucher voucher)
        {
            int value = 0;
            try
            {
                _context.Add(voucher);
                _context.SaveChanges();
                value = voucher.VoucherId;
            }
            catch (Exception) { value = 0; }
            return value;
        }

        public int EditVoucher(int id, Voucher voucher)
        {
            int value = 0;
            try
            {
                _context.Update(voucher);
                _context.SaveChanges();
                value = voucher.VoucherId;
            }
            catch (Exception) { value = 0; }
            return value;
        }
    }
}
