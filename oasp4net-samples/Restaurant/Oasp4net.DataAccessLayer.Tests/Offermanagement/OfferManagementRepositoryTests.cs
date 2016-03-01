using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Oasp4net.DataAccessLayer.Offermanagement.Model;
using Oasp4net.Infrastructure.EntityExtensions;

namespace Oasp4net.DataAccessLayer.Offermanagement
{
    [TestClass()]
    public class OfferManagementRepositoryTests
    {
        [TestMethod()]
        public void FindOffersTest()
        {
            var data = PrepareOfferList();
            var mockedDbset = new Mock<DbSet<Offer>>();
            mockedDbset.As<IQueryable<Offer>>().Setup(s => s.Provider).Returns(data.Provider);
            mockedDbset.As<IQueryable<Offer>>().Setup(s => s.ElementType).Returns(data.ElementType);
            mockedDbset.As<IQueryable<Offer>>().Setup(s => s.Expression).Returns(data.Expression);
            mockedDbset.As<IQueryable<Offer>>().Setup(s => s.GetEnumerator()).Returns(data.GetEnumerator());
            var mockedContext = new Mock<RestaurantContext>();
            mockedContext.Setup(c => c.Offers).Returns(mockedDbset.Object);
            var repository = new OfferManagementRepository(mockedContext.Object);


            var result = repository.FindOffers(new SearchRequest()
            {
                Pagination = new Pagination() {Page = 5, Size = 10}
            });

            Assert.AreEqual(10,result.Result.Count,"Inproper page size");
            Assert.AreEqual(100,result.Pagination.Total);
            Assert.AreEqual(5,result.Pagination.Page);
        }

        IQueryable<Offer> PrepareOfferList()
        {
            var list = new List<Offer>();
            for (int i = 0; i < 100; i++)
            {
                list.Add(new Offer()
                {
                    OfferId = i,
                    DrinkId = i+10,
                    MealId = i+7,
                    Number = i+1,
                    OfferState = OfferState.Normal
                });
            }
            return list.AsQueryable();
        } 
    }
}