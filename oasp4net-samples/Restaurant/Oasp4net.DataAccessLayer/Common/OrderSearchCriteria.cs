using Oasp4net.DataAccessLayer.Salesmanagement.Model;

namespace Oasp4net.DataAccessLayer.Common
{
    /// <summary>
    /// Represents search criteria to search for orders
    /// </summary>
    public class OrderSearchCriteria
    {
        /// <summary>
        /// get and set the OrderState
        /// </summary>
        public OrderState OrderState { get; set; }

        /// <summary>
        /// Get and set the table id
        /// </summary>
        public long TableId { get; set; }
    }
}
