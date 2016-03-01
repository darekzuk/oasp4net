
using System.Runtime.Serialization;

namespace Oasp4net.DataAccessLayer.Salesmanagement.Model
{
    /// <summary>
    /// Represents an Order State
    /// </summary>
    public enum OrderState
    {
        /// <summary>
        /// State Open
        /// </summary>
        [EnumMember(Value="OPEN")]
        Open,

        /// <summary>
        /// State closed
        /// </summary>
        [EnumMember(Value = "CLOSED")]
        Closed
    }
}
