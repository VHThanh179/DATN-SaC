using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Share.Models
{
    public class TotalStatistical
    {
        [Key]
        public int TotalStatisticallId { get; set; }

        [Display(Name = "Số lượng đăng ký")]
        public int? TotalQuantityRegister { get; set; }

        [Display(Name = "Số lượng đơn hàng")]
        public int? TotalQuantityOrder { get; set; }

        [Display(Name = "Doanh thu")]
        [Column(TypeName = "money")]
        public float? TotalRevenue { get; set; }

        [Display(Name = "Vận chuyển")]
        [Column(TypeName = "money")]
        public float? TotalTransport { get; set; }

        [Display(Name = "Tổng doanh thu")]
        [Column(TypeName = "money")]
        public float? TotalAllRevenue { get; set; }
    }
}
