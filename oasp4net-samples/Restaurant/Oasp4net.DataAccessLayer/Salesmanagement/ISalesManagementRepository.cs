using System.Collections.Generic;
using Oasp4net.DataAccessLayer.Common;
using Oasp4net.DataAccessLayer.Salesmanagement.Model;
using Oasp4net.Infrastructure.EntityExtensions;

namespace Oasp4net.DataAccessLayer.Salesmanagement
{
    /// <summary>
    ///  A repository to query <see cref="RestaurantTable"/> entities.
    /// </summary>
    public interface ISalesManagementRepository
    {
        /// <summary>
        /// Find orders and order positions by the given search criteria
        /// </summary>
        /// <param name="searchCriteria">The search criteria</param>
        /// <returns>List of <see cref="CompositeOrder"/> objects</returns>
        SearchResponse<CompositeOrder> FindCompositeOrders(OrderSearchCriteria searchCriteria);

        /// <summary>
        /// Find orders by the given search criteria
        /// </summary>
        /// <param name="searchCriteria">Search Criteria</param>
        /// <returns>List of <see cref="Order"/> objects</returns>
        SearchResponse<Order> FindOrders(OrderSearchCriteria searchCriteria);

        /// <summary>
        /// Find order positions belonging to the order given by the order id
        /// </summary>
        /// <param name="orderId">The given order id</param>
        /// <returns>A list of <see cref="OrderPosition"/></returns>
        IList<OrderPosition> FindOrderPositionsByOrderId(long orderId);

        /// <summary>
        /// Saves an order and the order positions
        /// </summary>
        /// <param name="">The composite order</param>
        /// <returns>The persisted composite order</returns>
        CompositeOrder SaveOrder(CompositeOrder compositeOrder);
    }
}
