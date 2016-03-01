

using Oasp4net.DataAccessLayer.Common;
using Oasp4net.DataAccessLayer.Salesmanagement;
using System.Collections.Generic;
using Oasp4net.DataAccessLayer.Salesmanagement.Model;

namespace Oasp4net.BusinessLogicLayer.Salesmanagement.Interfaces
{
    /// <summary>
    /// Interface of find order position  services
    /// </summary>
    public interface IUcFindOrderPosition
    {
        /// <summary>
        /// Find a order position by the given id
        /// </summary>
        /// <param name="orderPositionId">Order position id</param>
        /// <returns>The <see cref="OrderPosition"/></returns>
        OrderPosition FindOrderPosition(long orderPositionId);

        /// <summary>
        /// Find a order positions by the given order id
        /// </summary>
        /// <param name="orderId">The order id</param>
        /// <returns>A list of <see cref="OrderPosition"/></returns>
        IList<OrderPosition> FindOrderPositionsByOrderId(long orderId);

        /// <summary>
        /// Find order positions by the given search criteria
        /// </summary>
        /// <param name="searchCriteria">Search criteria</param>
        /// <returns>A list of <see cref="OrderPosition"/></returns>
        IList<OrderPosition> FindOrderPositions(OrderPositionSearchCriteria searchCriteria);
        
    }
}
