using System.Collections.Generic;
using System.Linq;
using Oasp4net.DataAccessLayer.Offermanagement.Model;
using Oasp4net.Infrastructure.EntityExtensions;

namespace Oasp4net.DataAccessLayer.Offermanagement
{
    /// <summary>
    /// A repository implementation to query for <see cref="Offer"/> entities.
    /// </summary>
    public class OfferManagementRepository : IOfferManagementRepository
    {
        /// <summary>
        /// The given database context
        /// </summary>
        private readonly RestaurantContext context;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="context">Databasecontext</param>
        public OfferManagementRepository(RestaurantContext context)
        {
            this.context = context;
        }

        /// <summary>
        /// Loads all Products
        /// </summary>
        /// <returns>List of <see cref="Product"/></returns>
        public IList<Product> GetAllProducts()
        {
            return (from p in this.context.Products select p).ToList();
        }

        /// <summary>
        /// Implements <see cref="IOfferManagementRepository.FindAllOffers"/>
        /// </summary>
        /// <returns>A list of <see cref="Offer"/></returns>
        public IList<Offer> FindAllOffers()
        {
            return (from o in this.context.Offers select o).ToList();
        }

        /// <summary>
        /// Loads offers which satisfy the search request
        /// </summary>
        /// <param name="searchRequest"></param>
        /// <returns>Search response with <see cref="offer"/> "/></returns>
        public SearchResponse<Offer> FindOffers(SearchRequest searchRequest)
        {
            var pagination = searchRequest.Pagination;
            int skip = pagination.Page <= 0 ? 0 : (pagination.Page - 1) * pagination.Size;
            pagination.Total = context.Offers.Count();

            if (pagination.Size == 0)
            {
                pagination.Size = pagination.Total;
            }
            var offers = new List<Offer>();
            if (pagination.Total > 0)
            {
                offers = (from of in context.Offers orderby of.OfferId select of).Skip(skip).Take(pagination.Size).ToList();
            }

            return new SearchResponse<Offer>
            {
                Pagination = pagination,
                Result = offers
            };
        }        
    }
}
