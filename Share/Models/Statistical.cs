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

        [Display(Name = "Doanh thu tháng")]
        [Column(TypeName = "money")]
        public float MonthlyRevenue { get; set; }

        [Display(Name = "Doanh thu năm")]
        [Column(TypeName = "money")]
        public float AnnualRevenue { get; set; }
    }
}
