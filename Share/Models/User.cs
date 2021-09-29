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
        public string UserName { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string FullName { get; set; }

        [Column(TypeName = "varchar(50)"), MaxLength(50)]
        public string Email { get; set; }
        public DateTime DoB { get; set; }
        public Role Roles { get; set; }
        public bool Status { get; set; }
        public string Password { get; set; }

    }
}
