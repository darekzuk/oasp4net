﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oasp4net.ServiceLayer.Api.Model.Security
{
    public class TokenResponse
    {
        public string token { get; set; }
        public string headerName { get; set; }
    }
}
