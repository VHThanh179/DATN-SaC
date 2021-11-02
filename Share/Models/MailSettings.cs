﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Share.Models
{
    public class MailSettings
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public int Port { get; set; }
        public string FromEmail { get; set; }
        public string Host { get; set; }
    }
}
