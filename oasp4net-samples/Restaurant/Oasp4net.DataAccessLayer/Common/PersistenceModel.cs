
using System.ComponentModel.DataAnnotations;

namespace Oasp4net.DataAccessLayer.Common
{
    /// <summary>
    /// Abstract class for all entity classes
    /// </summary>
    public abstract class PersistenceModel
    {
        /// <summary>
        /// Get and set Rowversion for concurrency control
        /// </summary>
        [Timestamp]
        public byte[] RowVersion { get; set; }        
    }
}
