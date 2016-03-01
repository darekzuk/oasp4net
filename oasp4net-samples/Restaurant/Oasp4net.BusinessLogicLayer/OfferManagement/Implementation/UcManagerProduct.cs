using Oasp4net.BusinessLogicLayer.OfferManagement.Interfaces;
using Oasp4net.DataAccessLayer.Offermanagement;


namespace Oasp4net.BusinessLogicLayer.OfferManagement.Implementation
{
    /// <summary>
    /// Implements <see cref="IUcManagerProduct"/>
    /// </summary>
    public class UcManagerProduct : IUcManagerProduct
    {
        /// <summary>
        /// Access to OfferManagementRepository
        /// </summary>
        private readonly IOfferManagementRepository repository;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="repository">The injected repository</param>
        public UcManagerProduct(IOfferManagementRepository repository)
        {
            this.repository = repository;
        }
    }
}
