﻿using Share.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Share.Interfaces
{
    public interface IVoucherSvc
    {
        //async
        Task<List<Voucher>> GetAllVoucherAsync();        
        Task<Voucher> GetVoucherByCodeAsync(string vcode);       
        Task<int> AddVoucherAsync(Voucher voucher);       
        Task<int> EditVoucherAsync(Voucher voucher);
        
        //sync
        List<Voucher> GetAllVoucher();
        Voucher GetVoucher(int id);
        int AddVoucher(Voucher voucher);
        int EditVoucher(int id, Voucher voucher);
    }
}
