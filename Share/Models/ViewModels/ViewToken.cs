using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Share.Models.ViewModels
{
    public class ViewToken
    {
        //[Required]
        public string Token { get; set; }

        //[Required]
        public int customerID { get; set; }

        //public string ReturnUrl { get; set; }
    }
}
