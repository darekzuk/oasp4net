using System;
using Oasp4net.BusinessLogicLayer.Salesmanagement.Interfaces;
using Oasp4net.DataAccessLayer.Salesmanagement;
using Oasp4net.DataAccessLayer.Salesmanagement.Model;

namespace Oasp4net.BusinessLogicLayer.Salesmanagement.Implementation
{
    /// <summary>
    /// Implements <see cref="IUcManageBill"/>
    /// </summary>
    public class UcManageBill : IUcManageBill
    {
        /// <summary>
        /// Access to SalesManagementRepository
        /// </summary>
        private readonly ISalesManagementRepository repository;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="repository">The injected repository</param>
        public UcManageBill(ISalesManagementRepository repository)
        {
            this.repository = repository;
        }

        public Bill CreateBill(Bill bill)
        {
            throw new NotImplementedException();
        }

        public void DeleteBill(long billId)
        {
            throw new NotImplementedException();
        }

        public PaymentStatus DoPayment(Bill bill)
        {
            throw new NotImplementedException();
        }
    }
}
