using Oasp4net.DataAccessLayer.Common;

namespace Oasp4net.DataAccessLayer.Offermanagement.Model
{
    /// <summary>
    /// Represents an offer entity
    /// </summary>
    public class Offer : PersistenceModel
    {
        /// <summary>
        /// Key
        /// </summary>
        public long OfferId { get; set; }

        /// <summary>
        /// Get and sets the offer number
        /// </summary>
        public long Number { get; set; }

        /// <summary>
        /// Get and sets money
        /// </summary>        
        public decimal Amount{ get; set; }

        /// <summary>
        /// Foreign key
        /// </summary>
        public int? MealId { get; set; }

        /// <summary>
        /// Foreign key
        /// </summary>
        public int? DrinkId { get; set; }

        /// <summary>
        /// Foreign key
        /// </summary>
        public int? SideDishId { get; set; }

        /// <summary>
        /// get and set the meal
        /// </summary>        
        public virtual Meal Meal { get; set; }
        /// <summary>
        /// get and set a drink
        /// </summary>        
        public virtual Drink Drink { get; set; }

        /// <summary>
        /// get and set a sidedish
        /// </summary>        
        public virtual SideDish SideDish { get; set; }

        /// <summary>
        /// Get and set the offer state
        /// </summary>
        public OfferState OfferState { get; set; }
    }   
}
