using System.Collections.Generic;

namespace Oasp4net.DataAccessLayer.Salesmanagement.Model
{
    /// <summary>
    /// Represents a composite bill.
    /// </summary>
    public class CompositeBill 
    {
        /// <summary>
        /// Get and set the bill
        /// </summary>
        public Bill Bill { get; set; }

        /// <summary>
        /// Get and set the order position
        /// </summary>
        public List<OrderPosition> OrderPositions { get; set; }

    }
}
