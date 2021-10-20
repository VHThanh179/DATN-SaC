using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Share.Models.ViewModels
{
    public class Cart
    {
        public int CustomerId { get; set; }
        public List<CartItem> ListViewCart { get; set; } = new List<CartItem>();
        public float Total { get; set; }
    }

    public class CartItem
    {
        public Product product { get; set; }
        public int Quantity { get; set; }
        public float Price { get; set; }
    }

    public class ViewCart
    {
        public Product product { get; set; }
        public int Quantity { get; set; }
    }
}
