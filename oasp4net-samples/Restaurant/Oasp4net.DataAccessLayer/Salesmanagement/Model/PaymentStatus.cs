
namespace Oasp4net.DataAccessLayer.Salesmanagement.Model
{
    /// <summary>
    /// Enum for status payment
    /// </summary>
    public enum PaymentStatus
    {
        /// <summary>
        /// Status succes describes a succesful payment
        /// </summary>
        Success,

        /// <summary>
        /// This status describes a unsuccessful payment transaction. The input data is not correct
        /// </summary>
        InputDataError,

        /// <summary>
        ///  This status describes a unsuccessful payment transaction. The connection timed out.
        /// </summary>
        TimeOutError

    }
}
