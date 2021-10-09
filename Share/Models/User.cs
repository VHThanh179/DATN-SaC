using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Share.Models
{
    public enum Role
    {
        [Display(Name = "Quản lý")]
        Manager = 1,
        [Display(Name = "Nhân viên")]
        Staff = 2
    }
    public class User
    {
        [Key]
        public int UserId { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        [Display(Name = "Tài khoản"), Required(ErrorMessage = "Mời nhập tài khoản")]
        public string UserName { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        [Display(Name = "Họ tên"), Required(ErrorMessage = "Mời nhập họ tên")]
        public string FullName { get; set; }

        [Column(TypeName = "varchar(50)"), MaxLength(50)]
        [DataType(DataType.EmailAddress), Required(ErrorMessage = "Mời nhập Email")]
        [RegularExpression(@"[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,4}", ErrorMessage = "Email không hợp lệ")]
        public string Email { get; set; }

        [Column(TypeName = "date")]
        [DataType(DataType.Date)]
        [Display(Name = "Ngày sinh")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DoB { get; set; }

        [Display(Name = "Vai trò")]
        [Required(ErrorMessage = "Mời chọn chức vụ"), Range(1, int.MaxValue, ErrorMessage = "Vui lòng chọn chức vụ")]
        public Role Roles { get; set; }

        [Display(Name = "Trạng thái hoạt động")]
        public bool Status { get; set; }

        [Display(Name = "Nhập lại mật khẩu")]
        [Column(TypeName = "varchar(50)"), MaxLength(50)]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Mật khẩu không khớp")]
        [NotMapped]
        public string ConfirmPass { get; set; }

        [Display(Name = "Mật khẩu")]
        [Column(TypeName = "varchar(50)"), MaxLength(50)]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
