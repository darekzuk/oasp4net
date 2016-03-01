using Oasp4net.DataAccessLayer.Offermanagement;
using Oasp4net.DataAccessLayer.Offermanagement.Model;
using Oasp4net.DataAccessLayer.Salesmanagement;
using Oasp4net.DataAccessLayer.Salesmanagement.Model;


namespace Oasp4net.BusinessLogicLayer.Salesmanagement.Interfaces
{
    /// <summary>
    /// Interface to manage manage order position services
    /// </summary>
    public interface IUcManageOrderPosition
    {
        /// <summary>
        /// Creates a <see cref="OrderPosition"/> for the given <see cref="Order"/> and given <see cref="Offer"/>
        /// </summary>
        /// <param name="offer">The offer</param>
        /// <param name="order">The order</param>
        /// <param name="comment">A comment</param>
        /// <returns>The persisted <see cref="OrderPosition"/></returns>
        OrderPosition CreateOrderPosition(Offer offer, Order order, string comment);

        /// <summary>
        /// Creates or updates an <see cref="OrderPosition"/> for the given <see cref="OrderPosition"/>
        /// </summary>
        /// <param name="orderPosition">The order postion</param>
        /// <returns>The persisted <see cref="OrderPosition"/></returns>
        OrderPosition SaveOrderPosition(OrderPosition orderPosition);
    }
}
