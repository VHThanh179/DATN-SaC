using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Share.Models
{
    public class Statistical
    {
        [Key]
        public int StatisticalId { get; set; }

        [Display(Name = "Tháng")]
        public int StatisticalMonth { get; set; }

        [Display(Name = "Số lượng đăng ký")]
        public int QuantityRegister { get; set; }

        [Display(Name = "Số lượng đơn hàng")]
        public int QuantityOrder { get; set; }

        [Display(Name = "Doanh thu")]
        [Column(TypeName = "money")]
        public float Revenue { get; set; }

        [Display(Name = "Vận chuyển")]
        [Column(TypeName = "money")]
        public float Transport { get; set; }

        [Display(Name = "Tổng doanh thu")]
        [Column(TypeName = "money")]
        public float TotalRevenue { get; set; }
    }
}
