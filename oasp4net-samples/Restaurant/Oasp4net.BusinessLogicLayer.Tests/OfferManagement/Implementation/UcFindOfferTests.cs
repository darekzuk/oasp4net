using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Oasp4net.DataAccessLayer.Offermanagement;

namespace Oasp4net.BusinessLogicLayer.Tests.OfferManagement.Implementation
{
    [TestClass()]
    public class UcFindOfferTests
    {
        [TestMethod()]
        public void FindOffersTest()
        {
            var mockedRepository = new Mock<IOfferManagementRepository>();
            Assert.Fail();
        }
    }
}