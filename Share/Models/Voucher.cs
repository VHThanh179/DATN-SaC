using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Share.Models
{
    public enum CategoryDiscount
    {
        [Display(Name = "Phần trăm")]
        Percent = 1,
        [Display(Name = "Tiền mặt")]
        Cash = 2
    }
    public class Voucher
    {
        [Key]
        public int VoucherId { get; set; }

        [ForeignKey("Customer")]
        public int CustomerId { get; set; }

        [Column(TypeName = "varchar(200)"), MaxLength(200)]
        [Required(ErrorMessage = "Bạn cần nhập mã voucher!")]
        [Display(Name = "Mã voucher")]
        public int VoucherCode { get; set; }

        [Required, Range(0, int.MaxValue, ErrorMessage = "Bạn cần chọn ngày bắt đầu!")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        [DataType(DataType.Date)]
        [Display(Name = "Ngày bắt đầu")]
        public DateTime StartDate { get; set; }

        [Required, Range(0, double.MaxValue, ErrorMessage = "Bạn cần chọn ngày bắt đầu!")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        [DataType(DataType.Date)]
        [Display(Name = "Ngày kết thúc")]
        public DateTime EndDate { get; set; }

        [Required, Range(0, int.MaxValue, ErrorMessage = "Bạn cần chọn trạng thái!")]
        [Display(Name = "Trạng thái")]
        public bool Status { get; set; }

        [Required, Range(0, int.MaxValue, ErrorMessage = "Bạn cần chọn số lượng voucher!")]
        [Display(Name = "Số lượng voucher")]
        public bool VoucherQuantity { get; set; }

        [Display(Name = "Loại giảm giá")]
        public CategoryDiscount CategoryDiscount { get; set; }

        [Display(Name = "Giá trị")]
        public double Value { get; set; }

        public Customer Customer { get; set; }        
    }
}
