using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oasp4net.ServiceLayer.Api.Model.Security
{
    public class CurrentUserResponse
    {
        public int id { get; set; }
        public string name { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string role { get; set; }
    }
}
