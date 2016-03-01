using System;
using System.Collections.Generic;
using Oasp4net.BusinessLogicLayer.OfferManagement.Interfaces;
using Oasp4net.DataAccessLayer.Offermanagement;
using Oasp4net.DataAccessLayer.Offermanagement.Model;
using Oasp4net.Infrastructure.EntityExtensions;

namespace Oasp4net.BusinessLogicLayer.OfferManagement.Implementation
{
    /// <summary>
    /// Implements <see cref="IOfferManagement"/>
    /// </summary>
    public class OfferManagement : IOfferManagement
    {
        /// <summary>
        /// The UcFindOffer
        /// </summary>
        private readonly IUcFindOffer ucFindOffer;

        /// <summary>
        /// The UcFindProduct
        /// </summary>
        private readonly IUcFindProduct ucFindProduct;

        /// <summary>
        /// The UcFindSpecial
        /// </summary>
        private readonly IUcFindSpecial ucFindSpecial;

        /// <summary>
        /// The UcManagerOffer
        /// </summary>
        private readonly IUcManagerOffer ucManagerOffer;

        /// <summary>
        /// The UcManagerProduct
        /// </summary>
        private readonly IUcManagerProduct ucManagerProduct;

        /// <summary>
        /// The UcManagerSpecial
        /// </summary>
        private readonly IUcManagerSpecial ucManagerSpecial;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="ucFindOffer">Injected UcFindOffer</param>
        /// <param name="ucFindProduct">Injected UcFindProduct</param>
        /// <param name="ucFindSpecial">Injected UcFindSpecial</param>
        /// <param name="ucManagerOffer">Injected UcManagerOffer</param>
        /// <param name="ucManagerProduct">Injected UcManagerProduct</param>
        /// <param name="ucManagerSpecial">Injected UcManagerSpecial</param>
        public OfferManagement(IUcFindOffer ucFindOffer, IUcFindProduct ucFindProduct, IUcFindSpecial ucFindSpecial, 
                               IUcManagerOffer ucManagerOffer, IUcManagerProduct ucManagerProduct, IUcManagerSpecial ucManagerSpecial)
        {
            this.ucFindOffer = ucFindOffer;
            this.ucFindProduct = ucFindProduct;
            this.ucFindSpecial = ucFindSpecial;
            this.ucManagerOffer = ucManagerOffer;
            this.ucManagerProduct = ucManagerProduct;
            this.ucManagerSpecial = ucManagerSpecial;
        }

        /// <summary>
        /// Implements <see cref="IUcFindProduct.GetAllProducts"/>
        /// </summary>
        /// <returns>List of <see cref="Product"/></returns>
        public IList<Product> GetAllProducts()
        {
            return ucFindProduct.GetAllProducts();
        }

        /// <summary>
        /// Implements <see cref="IUcFindOffer.FindAllOffers"/>
        /// </summary>
        /// <returns>A list of <see cref="Offer"/> objects</returns>
        public IList<Offer> FindAllOffers()
        {
            return ucFindOffer.FindAllOffers();
        }

        public SearchResponse<Offer> FindOffers(SearchRequest searchRequest)
        {
            return ucFindOffer.FindOffers(searchRequest);
        }
    }
}
