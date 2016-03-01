using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oasp4net.ServiceLayer.Api.Model.Security
{
    public class LoginRequest
    {
        public string j_username { get; set; }
        public string j_password { get; set; }
    }
}
