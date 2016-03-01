using Oasp4net.DataAccessLayer.Common;

namespace Oasp4net.DataAccessLayer.Salesmanagement.Model
{
    /// <summary>
    /// Represents a Order Entity
    /// </summary>
    public class Order : PersistenceModel
    {
        /// <summary>
        /// Key
        /// </summary>
        public long OrderId { get; set; }

        /// <summary>
        /// Get and sets the table id
        /// </summary>
        public long RestaurantTableId { get; set; }

        /// <summary>
        /// Get and sets the order state
        /// </summary>
        public OrderState OrderState { get; set; }
    }
}
