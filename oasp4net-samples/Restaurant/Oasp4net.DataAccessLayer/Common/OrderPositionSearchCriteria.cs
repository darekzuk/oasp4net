

using Oasp4net.DataAccessLayer.Salesmanagement.Model;

namespace Oasp4net.DataAccessLayer.Common
{
    public class OrderPositionSearchCriteria
    {
        /// <summary>
        /// Get and set the order position state
        /// </summary>
        public OrderPositionState OrderPositionstate { get; set; }

        /// <summary>
        /// Get and sets the order id
        /// </summary>
        public long OrderId { get; set; }

        /// <summary>
        /// Get and set the cook id
        /// </summary>
        public long CockId { get; set; }

        /// <summary>
        /// Get and set meal or sidedish flag
        /// </summary>
        public bool MealOrSideDish { get; set; }
    }
}
