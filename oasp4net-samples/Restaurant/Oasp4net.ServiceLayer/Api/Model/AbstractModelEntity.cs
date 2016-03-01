

using System.ComponentModel.DataAnnotations;

namespace Oasp4net.ServiceLayer.Api.Model
{
    /// <summary>
    /// Abstract class for all transferobject classes
    /// </summary>
    public abstract class AbstractModelEntity
    {
        /// <summary>
        /// Get and set Rowversion for concurrency control
        /// </summary>
        [Timestamp]
        public byte[] RowVersion { get; set; }
    }
}
