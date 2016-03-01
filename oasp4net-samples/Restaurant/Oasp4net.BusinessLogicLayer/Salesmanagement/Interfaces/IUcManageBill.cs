using Oasp4net.DataAccessLayer.Salesmanagement;
using Oasp4net.DataAccessLayer.Salesmanagement.Model;

namespace Oasp4net.BusinessLogicLayer.Salesmanagement.Interfaces
{
    /// <summary>
    /// Interface to manage bill  services
    /// </summary>
    public interface IUcManageBill
    {
        /// <summary>
        /// Create a bill and save the bill into datatabse
        /// </summary>
        /// <param name="bill"></param>
        /// <returns></returns>
        Bill CreateBill(Bill bill);

        /// <summary>
        /// Deletes a bill 
        /// </summary>
        /// <param name="billId">Bill id</param>
        void DeleteBill(long billId);

        /// <summary>
        /// Executes a payment
        /// </summary>
        /// <param name="bill">The bill</param>
        /// <returns>A <see cref="PaymentStatus"/></returns>
        PaymentStatus DoPayment(Bill bill);


    }
}
