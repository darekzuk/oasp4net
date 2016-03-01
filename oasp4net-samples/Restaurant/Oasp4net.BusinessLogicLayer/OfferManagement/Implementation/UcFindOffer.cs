using Oasp4net.BusinessLogicLayer.OfferManagement.Interfaces;
using Oasp4net.DataAccessLayer.Offermanagement;
using Oasp4net.Infrastructure.EntityExtensions;
using System.Collections.Generic;
using Oasp4net.DataAccessLayer.Offermanagement.Model;

namespace Oasp4net.BusinessLogicLayer.OfferManagement.Implementation
{
    /// <summary>
    /// Implements <see cref="IUcFindOffer"/>
    /// </summary>
    public class UcFindOffer : IUcFindOffer
    {
        /// <summary>
        /// Access to OfferManagementRepository
        /// </summary>
        private readonly IOfferManagementRepository repository;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="repository">The injected repository</param>
        public UcFindOffer(IOfferManagementRepository repository)
        {
            this.repository = repository;
        }

        /// <summary>
        /// Implements <see cref="IUcFindOffer.FindAllOffers"/>
        /// </summary>
        /// <returns>A list of <see cref="Offer"/></returns>
        public IList<Offer> FindAllOffers()
        {
            return repository.FindAllOffers();
        }

        /// <summary>
        /// Implements <see cref="IUcFindOffer.FindOffers(SearchRequest)"/>
        /// </summary>
        /// <param name="searchRequest">The search request</param>
        /// <returns>Search Response</returns>
        public SearchResponse<Offer> FindOffers(SearchRequest searchRequest)
        {
            return repository.FindOffers(searchRequest);
        }
    }
}
