
using Oasp4net.DataAccessLayer.Offermanagement;
using System.Collections.Generic;
using Oasp4net.DataAccessLayer.Offermanagement.Model;

namespace Oasp4net.BusinessLogicLayer.OfferManagement.Interfaces
{
    /// <summary>
    /// Interface of <see cref="UcFindOffer"/>
    /// </summary>
    public interface IUcFindProduct
    {
        /// <summary>
        /// Get all products
        /// </summary>
        /// <returns>A list of <see cref="Product"/></returns>
        IList<Product> GetAllProducts();
    }
}
