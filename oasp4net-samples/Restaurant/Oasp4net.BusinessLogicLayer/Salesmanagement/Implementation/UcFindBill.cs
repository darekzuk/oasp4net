using System;
using Oasp4net.BusinessLogicLayer.Salesmanagement.Interfaces;
using Oasp4net.DataAccessLayer.Salesmanagement;
using Oasp4net.DataAccessLayer.Salesmanagement.Model;

namespace Oasp4net.BusinessLogicLayer.Salesmanagement.Implementation
{
    /// <summary>
    /// Implements <see cref="IUcFindBill"/>
    /// </summary>
    public class UcFindBill : IUcFindBill
    {
        /// <summary>
        /// Access to SalesManagementRepository
        /// </summary>
        private readonly ISalesManagementRepository repository;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="repository">The injected repository</param>
        public UcFindBill(ISalesManagementRepository repository)
        {
            this.repository = repository;
        }

        public CompositeBill FindBill(long billId)
        {
            throw new NotImplementedException();
        }
    }
}
