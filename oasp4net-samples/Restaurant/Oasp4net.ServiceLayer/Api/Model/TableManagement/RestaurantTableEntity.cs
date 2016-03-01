

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Oasp4net.DataAccessLayer.Tablemanagement.Model;

namespace Oasp4net.ServiceLayer.Api.Model.TableManagement
{
    /// <summary>
    /// Transfer Object for RetsaurantTable entity
    /// </summary>
    public class RestaurantTableEntity : AbstractModelEntity
    {
        /// <summary>
        /// The Id
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public int RestaurantTableId { get; set; }

        /// <summary>
        /// Get and sets waiterid
        /// </summary>
        [JsonProperty(PropertyName = "number")]
        public long Number { get; set; }

        /// <summary>
        /// Get and sets waiterid
        /// </summary>
        [JsonProperty(PropertyName = "waiterId")]
        public long? WaiterId { get; set; }

        /// <summary>
        /// Get and sets TableState
        /// </summary>
        [JsonProperty(PropertyName = "state")]
        [JsonConverter(typeof(StringEnumConverter))]
        public TableState TableState { get; set; }
    }
}
