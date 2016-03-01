

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Oasp4net.DataAccessLayer.Salesmanagement.Model;

namespace Oasp4net.ServiceLayer.Api.Model.SalesManagement
{
    /// <summary>
    /// Transport object for an order
    /// </summary>
    public class OrderEntity : AbstractModelEntity
    {
        /// <summary>
        /// Get and set the order id
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public long OrderId { get; set; }

        /// <summary>
        /// Get and sets the table id
        /// </summary>
        [JsonProperty(PropertyName = "tableId")]
        public long RestaurantTableId { get; set; }

        /// <summary>
        /// Get and sets the order state
        /// </summary>
        [JsonProperty(PropertyName = "state")]
        [JsonConverter(typeof(StringEnumConverter))]
        public OrderState OrderState { get; set; }
    }
}
