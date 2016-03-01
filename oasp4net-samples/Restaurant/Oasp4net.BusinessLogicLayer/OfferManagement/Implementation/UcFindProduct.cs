using Oasp4net.BusinessLogicLayer.OfferManagement.Interfaces;
using System.Collections.Generic;
using Oasp4net.DataAccessLayer.Offermanagement;
using Oasp4net.DataAccessLayer.Offermanagement.Model;

namespace Oasp4net.BusinessLogicLayer.OfferManagement.Implementation
{   
    /// <summary>
    /// Implements <see cref="IUcFindProduct"/>
    /// </summary>
    public class UcFindProduct : IUcFindProduct
    {
        /// <summary>
        /// Access to OfferManagementRepository
        /// </summary>
        private readonly IOfferManagementRepository offerManagementRepo;


        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="repository">The injected repository</param>
        public UcFindProduct(IOfferManagementRepository repository)
        {
            this.offerManagementRepo = repository;
        }

        /// <summary>
        /// Implements <see cref="IUcFindProduct.GetAllProducts"/>
        /// </summary>
        /// <returns>List of <see cref="Product"/></returns>
        public IList<Product> GetAllProducts()
        {
            return offerManagementRepo.GetAllProducts();
        }
    }
}
