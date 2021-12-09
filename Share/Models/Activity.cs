using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Share.Models
{
    public class Activity
    {
        [Key]
        public int ActivityID { get; set; }

        public string UserName { get; set; }

        public string CusEmail { get; set; }

        public DateTime LoginTime { get; set; }
    }
}
