using Share.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Share.Interfaces
{
    public interface IVoucherSvc
    {
        Task<List<Voucher>> GetVouchersAsync();
        List<Voucher> GetAllVoucher();
        Task<Voucher> GetVoucherAsync(int id);
        Voucher GetVoucher(int id); 
        Task<int> AddVoucherAsync(Voucher voucher);
        int AddVoucher(Voucher voucher);
        Task<int> EditVoucherAsync(int id, Voucher voucher);
        int EditVoucher(int id, Voucher voucher);
    }
}
