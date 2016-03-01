using Oasp4net.DataAccessLayer.Offermanagement;
using Oasp4net.Infrastructure.EntityExtensions;
using System.Collections.Generic;
using Oasp4net.DataAccessLayer.Offermanagement.Model;

namespace Oasp4net.BusinessLogicLayer.OfferManagement.Interfaces
{
    /// <summary>
    /// Interface of
    /// </summary>
    public interface IUcFindOffer
    {
        /// <summary>
        /// Loads all offers
        /// </summary>
        IList<Offer> FindAllOffers();

        /// <summary>
        /// Loads offers which satisfy the search request
        /// </summary>
        /// <param name="searchRequest"></param>
        /// <returns>Search response with offers and pagination information</returns>
        SearchResponse<Offer> FindOffers(SearchRequest searchRequest);
    }
}
