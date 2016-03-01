
using System.Runtime.Serialization;

namespace Oasp4net.DataAccessLayer.Tablemanagement.Model
{
    /// <summary>
    /// Represents a table state
    /// </summary>
    public enum TableState
    {
        /// <summary>
        /// Table is free
        /// </summary>
        [EnumMember(Value="FREE")]
        Free,

        /// <summary>
        /// Table is reserved
        /// </summary>
        [EnumMember(Value = "RESERVED")]
        Reserved,

        /// <summary>
        /// Table is occupied
        /// </summary>
        [EnumMember(Value = "OCCUPIED")]
        Occupied
    }
}
