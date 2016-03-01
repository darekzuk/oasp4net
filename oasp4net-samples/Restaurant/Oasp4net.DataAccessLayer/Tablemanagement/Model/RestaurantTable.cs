using System.ComponentModel.DataAnnotations;
using Oasp4net.DataAccessLayer.Common;

namespace Oasp4net.DataAccessLayer.Tablemanagement.Model
{
    /// <summary>
    /// Represents a restaurant table entity
    /// </summary>
    public class RestaurantTable : PersistenceModel
    {
        /// <summary>
        /// The Id
        /// </summary>
        [Key]
        public long RestaurantTableId { get; set; }

        /// <summary>
        /// Get and sets the table number
        /// </summary>
        public int Number { get; set; }

        /// <summary>
        /// Get and sets waiterid
        /// </summary>
        public long? WaiterId { get; set; }

        /// <summary>
        /// Get and sets TableState
        /// </summary>
        public TableState TableState { get; set; }
    }
}
