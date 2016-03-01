using Oasp4net.DataAccessLayer.Common;

namespace Oasp4net.DataAccessLayer.Salesmanagement.Model
{
    /// <summary>
    /// Entity clas fpr OrderPostion
    /// </summary>
    public class OrderPosition : PersistenceModel
    {
        /// <summary>
        /// Key
        /// </summary>
        public long OrderPositionId { get; set; }
        /// <summary>
        /// Get and sets the cook Id
        /// <remarks>Could be null</remarks>
        /// </summary>
        public long? CoockId { get; set; }
        /// <summary>
        /// Gets and sets the offer id
        /// </summary>
        public long OfferId { get; set; }
        /// <summary>
        /// Gets and sets the offer name
        /// </summary>
        public string OfferName { get; set; }
        /// <summary>
        /// Gets and sets a comment
        /// </summary>
        public string Comment { get; set; }
        /// <summary>
        /// Gets and sets the price
        /// </summary>
        public decimal Price { get; set; }
        /// <summary>
        /// Foreign key
        /// </summary>
        public long OrderId { get; set; }
        /// <summary>
        /// Gets and sets teh Order
        /// </summary>
        public virtual Order Order { get; set; }
        /// <summary>
        /// Gets and sets the order position
        /// </summary>       
        public OrderPositionState OrderPostionState { get; set; }

    }
}
