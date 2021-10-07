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
        Task<Voucher> GetVoucherAsync(int id);
        Task<int> AddVoucherAsync(Voucher voucher);
        Task<int> EditVoucherAsync(int id, Voucher voucher);
    }
}
