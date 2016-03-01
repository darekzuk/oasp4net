

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Oasp4net.DataAccessLayer.Salesmanagement.Model;

namespace Oasp4net.ServiceLayer.Api.Model.SalesManagement
{
    /// <summary>
    /// Transport object for an order
    /// </summary>
    public class OrderPositionEntity : AbstractModelEntity
    {
        /// <summary>
        /// Get and set the orderposition
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public long OrderPositionId { get; set; }
        /// <summary>
        /// Get and sets the cook Id
        /// <remarks>Could be null</remarks>
        /// </summary>
        [JsonProperty(PropertyName = "cookId")]
        public long? CoockId { get; set; }
        /// <summary>
        /// Gets and sets the offer id
        /// </summary>
        [JsonProperty(PropertyName = "offerId")]
        public long OfferId { get; set; }
        /// <summary>
        /// Gets and sets the offer name
        /// </summary>
        [JsonProperty(PropertyName = "offerName")]
        public string OfferName { get; set; }
        /// <summary>
        /// Get and set the order id for the corresponding order
        /// </summary>        
        [JsonProperty(PropertyName = "orderId")]
        public long OrderId { get; set; }
        /// <summary>
        /// Gets and sets a comment
        /// </summary>
        [JsonProperty(PropertyName = "comment")]
        public string Comment { get; set; }
        /// <summary>
        /// Gets and sets the price
        /// </summary>
        [JsonProperty(PropertyName = "price")]
        public decimal Price { get; set; }
        
        /// Gets and sets the order position
        /// </summary>
        [JsonProperty(PropertyName = "state")]
        [JsonConverter(typeof(StringEnumConverter))]
        public OrderPositionState OrderPostionState { get; set; }      
    }
}
