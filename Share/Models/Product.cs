using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Share.Models
{
    public enum Category
    {
        [Display(Name = "Ba lô")]
        Backpack = 1,
        [Display(Name = "Phụ kiện")]
        Accessories = 2
    }
    public class Product 
    {
        [Key]
        public int ProductId { get; set; }

        [StringLength(250)]
        [Required(ErrorMessage = "Bạn cần nhập tên sản phẩm")]
        [Display(Name = "Tên sản phẩm")]
        [Column(TypeName = "nvarchar(250)")]
        public string ProductName { get; set; }

        [Required(ErrorMessage = "Bạn cần nhập giá")]
        [Range(0, double.MaxValue, ErrorMessage = "Vui lòng nhập đúng")]
        [Display(Name = "Giá")]
        [Column(TypeName = "money")]
        public float Price { get; set; }

        [Required(ErrorMessage = "Mời chọn loại"), Range(1, int.MaxValue, ErrorMessage = "Vui lòng chọn phân loại")]
        [Display(Name = "Phân loại")]
        public Category Category { get; set; }

        [StringLength(200)]
        [Display(Name = "Hình ảnh")]
        public string Image { get; set; }

        [NotMapped]
        [Display(Name = "Chọn hình")]
        public IBrowserFile ImageFile { get; set; }

        [Required(ErrorMessage = "Mời nhập thông tin mô tả sản phẩm")]
        [Display(Name = "Mô tả")]
        [Column(TypeName = "nvarchar(max)")]
        public string Description { get; set; }

        [Display(Name = "Đang phục vụ")]
        public bool Status { get; set; }

    }
}
