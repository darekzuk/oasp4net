using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using Oasp4net.BusinessLogicLayer.OfferManagement.Implementation;
using Oasp4net.DataAccessLayer.Offermanagement;
using Oasp4net.ServiceLayer.Api.Model.Security;

namespace Oasp4net.ServiceLayer.Api
{
    public class SecurityController : ApiController
    {

        [HttpPost]
        [Route("oasp4j-sample-server/services/rest/login")]
        public void Login(LoginRequest param)
        {
            Console.WriteLine("Logged in user:" + param.j_username);
        }

        [HttpGet]
        [Route("oasp4j-sample-server/services/rest/security/v1/currentuser")]
        public CurrentUserResponse CurrentUser()
        {
            CurrentUserResponse response = new CurrentUserResponse()
            {
                id = 2,
                name = "waiter",
                firstName = "Willy",
                lastName = "Waiter",
                role = "WAITER"
            };

            return response;
        }

        [HttpGet]
        [Route("oasp4j-sample-server/services/rest/security/v1/csrftoken")]
        public TokenResponse Csrftoken()
        {
            TokenResponse response = new TokenResponse()
            {
                token = "55ccbd33-baff-456f-92a3-51fc167471b0",
                headerName = "X-CSRF-TOKEN"
            };

            return response;
        }


    }
}
