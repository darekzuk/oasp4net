using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oasp4net.DataAccessLayer.Offermanagement.Model;

namespace Oasp4net.ServiceLayer.Api.Model.OfferManagement
{
    public class OfferEntity : AbstractModelEntity
    {
        /// <summary>
        /// Get and set the offer id
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public long OfferId { get; set; }

        /// <summary>
        /// Get and sets the offer number
        /// </summary>
        [JsonProperty(PropertyName = "number")]
        public long Number { get; set; }

        /// <summary>
        /// Get and sets the menu item description
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// Get and sets money
        /// </summary>        
        [JsonProperty(PropertyName = "price")]
        public decimal Amount { get; set; }

        /// <summary>
        /// get and set the meal
        /// </summary>        
        [JsonProperty(PropertyName = "mealId")]
        public int?  MealId { get; set; }
        /// <summary>
        /// get and set a drink
        /// </summary>        
        [JsonProperty(PropertyName = "drinkId")]
        public int? DrinkId { get; set; }

        /// <summary>
        /// get and set a sidedish
        /// </summary>        
        [JsonProperty(PropertyName = "sideDishId")]
        public int? SideDishId { get; set; }

        /// <summary>
        /// Get and set the offer state
        /// </summary>
        [JsonProperty(PropertyName = "state")]
        [JsonConverter(typeof(StringEnumConverter))]
        public OfferState OfferState { get; set; }
    }
}
