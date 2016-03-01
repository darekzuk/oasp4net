using System.Collections.Generic;

namespace Oasp4net.DataAccessLayer.Salesmanagement.Model
{
    /// <summary>
    /// Represents a composite order.
    /// </summary>
    public class CompositeOrder
    {
        /// <summary>
        /// Get and set the order
        /// </summary>
        public Order Order { get; set; }

        /// <summary>
        /// Get and set the order positions
        /// </summary>
        public IList<OrderPosition> OrderPositions{ get; set;}
    }
}
