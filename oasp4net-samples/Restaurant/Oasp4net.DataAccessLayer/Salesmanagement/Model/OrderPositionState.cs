
using System.Runtime.Serialization;

namespace Oasp4net.DataAccessLayer.Salesmanagement.Model
{
    /// <summary>
    /// Represents an order postion state
    /// </summary>
    public enum OrderPositionState
    {
        /// <summary>
        /// State Ordered
        /// </summary>
        [EnumMember(Value = "ORDERED")]
        Ordered,

        /// <summary>
        /// State closed
        /// </summary>
        [EnumMember(Value = "CLOSED")]
        Closed,

        /// <summary>
        /// State Delivered
        /// </summary>
        [EnumMember(Value = "DELIVERED")]
        Delivered,

        /// <summary>
        /// State Prepered
        /// </summary>
        [EnumMember(Value = "PREPARED")]
        Prepared,

        /// <summary>
        /// State Payed
        /// </summary>
        [EnumMember(Value = "PAYED")]
        Payed,

        /// <summary>
        /// State Payed
        /// </summary>
        [EnumMember(Value = "CANCELLED")]
        Cancelled,
    }
}
