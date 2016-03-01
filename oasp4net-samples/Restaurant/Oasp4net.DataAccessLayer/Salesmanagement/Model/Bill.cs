using System.Collections.Generic;
using Oasp4net.DataAccessLayer.Common;
using Oasp4net.Infrastructure.DataTypes;

namespace Oasp4net.DataAccessLayer.Salesmanagement.Model
{
    /// <summary>
    /// Represents a bill entity
    /// </summary>
    public class Bill : PersistenceModel
    {

        /// <summary>
        /// Key
        /// </summary>
        public long BillId { get; set; }

        /// <summary>
        /// Get and sets Payed
        /// </summary>
        public bool Payed { get; set; }

        /// <summary>
        /// get and set the total price
        /// </summary>
        public Money Total { get; set; }

        /// <summary>
        /// get and set the tip
        /// </summary>
        public Money Tip { get; set; }

        /// <summary>
        /// Order Positions
        /// </summary>
        public virtual ICollection<OrderPosition> OrderPositions { get; set; }
    }
}
