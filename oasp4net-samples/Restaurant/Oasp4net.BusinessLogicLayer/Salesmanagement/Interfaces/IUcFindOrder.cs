using Oasp4net.DataAccessLayer.Common;
using Oasp4net.DataAccessLayer.Salesmanagement;
using Oasp4net.DataAccessLayer.Salesmanagement.Model;
using Oasp4net.Infrastructure.EntityExtensions;

namespace Oasp4net.BusinessLogicLayer.Salesmanagement.Interfaces
{
    /// <summary>
    /// Interface of find order  services
    /// </summary>
    public interface IUcFindOrder
    {
        /// <summary>
        /// Find an order by the given search criteria
        /// </summary>
        /// <param name="searchCriteria">The search criteria</param>
        /// <returns>The <see cref="SearchResponse{Order}"/></returns>
        SearchResponse<Order> FindOrders(OrderSearchCriteria searchCriteria);

        /// <summary>
        /// Find all composite orders by the given search criteria
        /// </summary>
        /// <param name="searchCriteria">The search criteria</param>
        /// <returns>The <see cref="SearchResponse{CompositeOrder}"/></returns>
        SearchResponse<CompositeOrder> FindCompositeOrders(OrderSearchCriteria searchCriteria);

        /// <summary>
        /// Find the coressponding order and orderposition by the given order
        /// </summary>
        /// <param name="order">The order</param>
        /// <returns>A <see cref="CompositeOrder"/></returns>
        CompositeOrder FindOrder(Order order);

        /// <summary>
        /// Find an order by the given id
        /// </summary>
        /// <param name="orderId">The order id</param>
        /// <returns>An <see cref="Order"/></returns>
        Order FindOrder(long orderId);

        /// <summary>
        /// Find an order by the given  table id
        /// </summary>
        /// <param name="tableId">The table id</param>
        /// <returns>The <see cref="Order"/></returns>
        Order FindOrderForTable(long tableId);
    }
}
