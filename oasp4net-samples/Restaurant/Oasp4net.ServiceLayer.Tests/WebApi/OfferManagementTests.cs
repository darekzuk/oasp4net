using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Web.Script.Serialization;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Owin.Testing;
using Oasp4net.ServiceLayer.Api.Model.OfferManagement;
using Oasp4net.ServiceLayer.App_Start;

namespace Oasp4net.ServiceLayer.Tests.WebApi
{
    /// <summary>
    /// Summary description for OfferManagementTests
    /// </summary>
    [TestClass]
    public class OfferManagementTests
    {


        [TestMethod]
        public void GetProducts()
        {
            using (var server = TestServer.Create<WebApiStartup>())
            {
                var response = server.HttpClient.GetAsync("oasp4j-sample-server/services/rest/offermanagement").Result;
                var result = response.Content.ReadAsStringAsync().Result;

                var list = new JavaScriptSerializer().Deserialize<List<ProductEntity>>(result);

                Assert.AreEqual(1, list.Count());
                Assert.AreEqual("Cola", list.First().Name);
            }
        }
    }
}
