﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Share.Interfaces
{
    public interface IMailSvc
    {
        public void SendEmailAsync(string ToEmail, string newPass);
    }
}
