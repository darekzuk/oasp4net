using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Oasp4net.ServiceLayer;
using Oasp4net.WebClient.Controllers;

namespace Oasp4net.ServiceLayer.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("Home Page", result.ViewBag.Title);
        }
    }
}
