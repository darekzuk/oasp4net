using Oasp4net.BusinessLogicLayer.OfferManagement.Interfaces;
using Oasp4net.DataAccessLayer.Offermanagement;

namespace Oasp4net.BusinessLogicLayer.OfferManagement.Implementation
{
    /// <summary>
    /// Implements <see cref="IUcManagerOffer"/>
    /// </summary>
    public class UcManagerOffer : IUcManagerOffer
    {
        /// <summary>
        /// Access to OfferManagementRepository
        /// </summary>
        private readonly IOfferManagementRepository repository;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="repository">The injected repository</param>
        public UcManagerOffer(IOfferManagementRepository repository)
        {
            this.repository = repository;
        }
    }
}
