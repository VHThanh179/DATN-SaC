using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Share.Models
{
    public enum OrderStatus
    {
        [Display(Name = "Mới đặt")]
        CurOrder = 1,
        [Display(Name = "Đang giao")]
        Delivering = 2,
        [Display(Name = "Đã giao")]
        Delivered = 3
    }
    public class Order
    {
        [Key]
        public int OrderId { get; set; }

        [Column(TypeName = "date")]
        [Display(Name = "Ngày đặt")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [Required(ErrorMessage = "Bạn cần chọn ngày đặt")]
        public DateTime OrderDate { get; set; }

        [Required, Range(0, double.MaxValue, ErrorMessage = "Bạn cần nhập giá")]
        [Display(Name = "Tổng tiền")]
        public float Total { get; set; }

        [Display(Name = "Trạng thái")]
        public OrderStatus OrderStatus { get; set; }

        [StringLength(250)]
        [Display(Name = "Ghi chú")]
        [Column(TypeName = "nvarchar(250)")]
        public string Notes { get; set; }

        public string CustomerId { get; set; }

        //public Customer Customer { get; set; }
        //public IList<OrderDetail> OrderDetails { get; set; }
    }
}
