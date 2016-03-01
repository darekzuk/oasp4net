using System.Runtime.Serialization;

namespace Oasp4net.DataAccessLayer.Offermanagement.Model
{
    /// <summary>
    /// Represents the state of data
    /// </summary>
    public enum OfferState
    {
        /// <summary>
        /// Table is free
        /// </summary>
        [EnumMember(Value = "NORMAL")]
        /// <summary>
        /// State normal
        /// </summary>
        Normal,

        [EnumMember(Value = "SPECIAL")]
        /// <summary>
        /// State special
        /// </summary>
        Special,

        [EnumMember(Value = "SOLDOUT")]
        /// <summary>
        /// State soldout
        /// </summary>
        Soldout
    }
}
