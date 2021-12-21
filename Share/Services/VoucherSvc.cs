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
        public async Task<Voucher> GetVoucherByCodeAsync(string vouchercode)
        {
            var voucher = await _context.Vouchers.Where(x => x.VoucherCode == vouchercode).FirstOrDefaultAsync();
            return voucher;
        }

        public async Task<List<Voucher>> GetAllVoucherAsync()
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

        public async Task<int> EditVoucherAsync(Voucher voucher)
        {
            int value = 0;
            try
            {
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
                voucher.Status = true;
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
                if (voucher.VoucherQuantity <= 0)
                {
                    voucher.Status = false;
                }
                else
                {
                    voucher.Status = true;
                }
                if (voucher.EndDate < DateTime.Today)
                {
                    voucher.Status = false;
                }
                else
                {
                    voucher.Status = true;
                }
                _context.Update(voucher);
                _context.SaveChanges();
                value = voucher.VoucherId;
            }
            catch (Exception) { value = 0; }
            return value;
        }
    }
}
