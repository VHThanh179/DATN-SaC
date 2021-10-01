﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Share.Models
{
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

        public Order Order { get; set; }
    }
}