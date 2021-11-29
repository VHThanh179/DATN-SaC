using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Share.Interfaces;
using Share.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VoucherController : ControllerBase
    {
        private readonly IVoucherSvc _voucherSvc;
        public VoucherController(IVoucherSvc voucherSvc)
        {
            _voucherSvc = voucherSvc;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Voucher>>> GetAllVoucher()
        {
            return await _voucherSvc.GetAllVoucherAsync();
        }
        //[HttpGet]
        //public async Task<ActionResult<Voucher>> GetVoucher([FromQuery] string code)
        //{
        //    return await _voucherSvc.GetVoucherByCodeAsync(code);
        //}

        [HttpPut("{id}")]
        public async Task<ActionResult<int>> UpdateVoucher(Voucher voucher)
        {
            try
            {
                await _voucherSvc.EditVoucherAsync(voucher);
            }
            catch
            {
                return BadRequest();
            }
            return Ok(1);
        }
    }
}
