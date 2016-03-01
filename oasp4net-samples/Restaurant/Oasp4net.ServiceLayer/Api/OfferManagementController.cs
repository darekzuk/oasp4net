using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using Oasp4net.DataAccessLayer.Offermanagement;
using Oasp4net.ServiceLayer.Api.Model.OfferManagement;
using Oasp4net.BusinessLogicLayer.OfferManagement.Interfaces;
using Oasp4net.DataAccessLayer.Offermanagement.Model;
using Oasp4net.Infrastructure.EntityExtensions;

namespace Oasp4net.ServiceLayer.Api
{
    /// <summary>
    /// RESTful services for Offer Management
    /// </summary>
    public class OfferManagementController : RestaurantController
    {
        /// <summary>
        /// Offer Management Interface
        /// </summary>
        public IOfferManagement offerManagement;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="offerManagement">Injected <see cref="IOfferManagement"/></param>
        public OfferManagementController(IOfferManagement offerManagement) : base()
        {
            this.offerManagement = offerManagement;
        }

        /// <summary>
        /// Get all products
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("oasp4j-sample-server/services/rest/tablemanagement/v1/product")]
        public IEnumerable<ProductEntity> FindAllProducts()
        {
            IList<Product> products = offerManagement.GetAllProducts();

            return products.Select(p =>
            AutoMapper.Mapper.Map<ProductEntity>(p));
        }

        /// <summary>
        /// Get all offers
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("oasp4j-sample-server/services/rest/offermanagement/v1/offer")]
        public IEnumerable<OfferEntity> FindAllOffers()
        {
            IList<Offer> offers = offerManagement.FindAllOffers();

            return offers.Select(p =>
            AutoMapper.Mapper.Map<OfferEntity>(p));
        }


        [HttpPost]
        [Route("oasp4j-sample-server/services/rest/offermanagement/v1/offer/search")]
        public SearchResponse<OfferEntity> Search(SearchRequest request)
        {
            SearchResponse<Offer> offers = offerManagement.FindOffers(request);

            var result = new SearchResponse<OfferEntity>
            {
                Result = offers.Result.Select(t => AutoMapper.Mapper.Map<OfferEntity>(t)).ToList(),
                Pagination = offers.Pagination
            };

            return result;
        }
    }
}
