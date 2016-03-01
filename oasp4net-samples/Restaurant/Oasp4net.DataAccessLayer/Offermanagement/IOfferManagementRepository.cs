using System.Collections.Generic;
using Oasp4net.DataAccessLayer.Offermanagement.Model;
using Oasp4net.Infrastructure.EntityExtensions;

namespace Oasp4net.DataAccessLayer.Offermanagement
{
    /// <summary>
    ///  A repository to query <see cref="Offer"/> entities.
    /// </summary>
    public interface IOfferManagementRepository
    {
        /// <summary>
        /// Loads all Products
        /// </summary>
        /// <returns>List of <see cref="Product"/></returns>
        IList<Product> GetAllProducts();

        /// <summary>
        /// Loads all offers
        /// </summary>
        /// <returns>A list of <see cref="Offer"/></returns>
        IList<Offer> FindAllOffers();

        /// <summary>
        /// Loads offers which satisfy the search request
        /// </summary>
        /// <param name="searchRequest"></param>
        /// <returns>Search response with <see cref="offer"/> "/></returns>
        SearchResponse<Offer> FindOffers(SearchRequest searchRequest);
    }
}
