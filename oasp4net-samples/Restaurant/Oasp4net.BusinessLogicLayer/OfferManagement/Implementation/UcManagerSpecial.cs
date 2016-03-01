using Oasp4net.BusinessLogicLayer.OfferManagement.Interfaces;
using Oasp4net.DataAccessLayer.Offermanagement;


namespace Oasp4net.BusinessLogicLayer.OfferManagement.Implementation
{
    /// <summary>
    /// Implements <see cref="IUcManagerSpecial"/>
    /// </summary>
    public class UcManagerSpecial : IUcManagerSpecial
    {
        /// <summary>
        /// Access to OfferManagementRepository
        /// </summary>
        private readonly IOfferManagementRepository repository;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="repository">The injected repository</param>
        public UcManagerSpecial(IOfferManagementRepository repository)
        {
            this.repository = repository;
        }
    }
}
