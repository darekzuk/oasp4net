using Oasp4net.DataAccessLayer.Salesmanagement;
using Oasp4net.DataAccessLayer.Salesmanagement.Model;
using Oasp4net.DataAccessLayer.Tablemanagement.Model;

namespace Oasp4net.BusinessLogicLayer.Salesmanagement.Interfaces
{
    /// <summary>
    /// Interface to manage manage order  services
    /// </summary>
    public interface IUcManageOrder
    {
        /// <summary>
        /// Creates or updates an order and order positions
        /// </summary>
        /// <param name="compositeOrder">Composite order</param>
        /// <returns>The persisted Order and order positions</returns>
        CompositeOrder SaveOrder(CompositeOrder compositeOrder);

        /// <summary>
        /// Saves or upadtes an order
        /// </summary>
        /// <param name="order">The order to save or to update</param>
        /// <returns>The saved order</returns>
        Order SaveOrder(Order order);

        /// <summary>
        /// Saves the order for the given table
        /// </summary>
        /// <param name="table">The table</param>
        /// <returns>The persisted order</returns>
        Order SaveOrder(RestaurantTable table);

        /// <summary>
        /// Deletes the order by the given order id
        /// </summary>
        /// <param name="orderId">The orderid</param>
        void DeleteOrder(long orderId);


    }
}
