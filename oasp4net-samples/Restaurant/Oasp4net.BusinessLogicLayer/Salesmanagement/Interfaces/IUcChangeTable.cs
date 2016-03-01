
namespace Oasp4net.BusinessLogicLayer.Salesmanagement.Interfaces
{
    /// <summary>
    /// Interface of change table services
    /// </summary>
    public interface IUcChangeTable
    {
        /// <summary>
        /// Chane an order to another table
        /// </summary>
        /// <param name="orderId">The order identified by orderId</param>
        /// <param name="newTableId">The new table identified by tableId</param>
        void ChangeTable(long orderId, long newTableId);
    }
}
