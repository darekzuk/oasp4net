using System.ComponentModel.DataAnnotations;
using Oasp4net.DataAccessLayer.Common;

namespace Oasp4net.DataAccessLayer.Offermanagement.Model
{
    /// <summary>
    /// Represents a menuitem entity
    /// </summary>
    public abstract class MenuItem : PersistenceModel
    {
        /// <summary>
        /// Get and sets the Id
        /// </summary>        
        [Key]
        public int Id { get; set; }
        /// <summary>
        /// Get and sets the Name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Gets and sets Description
        /// </summary>
        public string Description { get; set; }
    }
}
