using Newtonsoft.Json;
using System.Collections.Generic;


namespace Oasp4net.ServiceLayer.Api.Model.SalesManagement
{
    /// <summary>
    /// Transport object for an composite order object 
    /// </summary>
    public class CompositeOrderEntity
    {
        /// <summary>
        /// Get and set the order entity
        /// </summary>
        [JsonProperty(PropertyName = "order")]
        public OrderEntity OrderEntity { get; set; }

        /// <summary>
        /// Get and set order postion entities
        /// </summary>
        [JsonProperty(PropertyName = "positions")]
        public IList<OrderPositionEntity> OrderPositionEntities { get; set; }
    }
}
