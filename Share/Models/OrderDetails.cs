using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Share.Models
{    
    public class OrderDetails
    {
        [Key]
        public int DetailId { get; set; }

        [ForeignKey("Order")]
        public int OrderId { get; set; }

        [ForeignKey("Product")]
        public int ProductId { get; set; }

        [Required, Range(0, int.MaxValue, ErrorMessage = "Bạn cần nhập số lượng.")]
        [Display(Name = "Số lượng")]
        public int Quantity { get; set; }

        [Required, Range(0, double.MaxValue, ErrorMessage = "Bạn cần nhập thành tiền.")]
        [Display(Name = "Thành tiền")]
        public double TotalAmount { get; set; }

        [StringLength(200)]
        [Display(Name = "Ghi chú")]
        public string Notes { get; set; }

        public Order Order { get; set; }

        public Product Product { get; set; }
    }
}
