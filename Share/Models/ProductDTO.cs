using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Share.Models
{
    public class ProductDTO
    {
        public List<Product> Products { get; set; }
        public int TotalCount { get; set; }
    }
}
