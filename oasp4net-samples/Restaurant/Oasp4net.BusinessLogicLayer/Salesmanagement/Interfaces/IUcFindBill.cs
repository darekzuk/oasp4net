using Oasp4net.DataAccessLayer.Salesmanagement.Model;

namespace Oasp4net.BusinessLogicLayer.Salesmanagement.Interfaces
{
    /// <summary>
    /// Interface of find bill services
    /// </summary>
    public interface IUcFindBill
    {
        /// <summary>
        /// Find a bill with a special id
        /// </summary>
        /// <param name="billId">The bill id</param>
        /// <returns>A <see cref="CompositeBill"/></returns>
        CompositeBill FindBill(long billId);
    }
}
