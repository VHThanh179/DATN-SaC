﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Share.Models
{
    public class TokenResponseModel
    {
        public string JwtToken { get; set; }
        public bool FirstLogin { get; set; }
    }
}
