using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Share.Models
{
    public enum Partner
    {
        [Display(Name = "Grab")]
        Grab = 1,
        [Display(Name = "Now")]
        Now = 2,
        [Display(Name = "Gojek")]
        Gojek = 3
    }
   public class ShipInfo
    {
        [Key]
        public int ShipId { get; set; }

        [ForeignKey("Order")]
        public int OrderId { get; set; }

        [Display(Name = "Tên khách hàng")]
        [Required(ErrorMessage ="Nhập tên khách hàng")]
        [Column(TypeName = "nvarchar(100)")]
        public string CusName { get; set; }

        [Display(Name = "Địa chỉ")]
        [Column(TypeName = "nvarchar(200)"), Required(ErrorMessage ="Vui lòng nhập địa chỉ")]
        public string Address { get; set; }

        [Display(Name = "Số điện thoại")]
        [Column(TypeName = "varchar(20)"), MaxLength(20)]
        [RegularExpression(@"[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,4}"), Required(ErrorMessage ="Số điện thoại không đúng")]
        public string PhoneNumber { get; set; }
        [Required(ErrorMessage ="Hãy chọn hình thức")]
        [Display(Name = "Hình thức ship")]
        public bool ShippingMethod { get; set; }

        [Display(Name = "Ghi chú")]
        [Column(TypeName = "nvarchar(200)")]
        public string Notes { get; set; }

        [Display(Name = "Giá"),Required(ErrorMessage ="Vui lòng nhập giá")]
        public double Price { get; set; }

        [Display(Name = "Dịch vụ vận chuyển")]
        [Required(ErrorMessage = "Mời chọn dịch vụ vận chuyển"), Range(1, int.MaxValue, ErrorMessage = "Vui lòng chọn dịch vụ")]
        public Partner Partner { get; set; }

        public Order Order { get; set; }
    }
}