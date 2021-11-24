using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Share.Models.ViewModels
{
    public class APICart
    {
        public Cart cart { get; set; }
        public ShipInfo shipInfo { get; set; }
        public string voucherCode { get; set; }
    }
}
