using System;
using Oasp4net.BusinessLogicLayer.Salesmanagement.Interfaces;
using Oasp4net.DataAccessLayer.Salesmanagement;

namespace Oasp4net.BusinessLogicLayer.Salesmanagement.Implementation
{
    /// <summary>
    /// Implements <see cref="IUcChangeTable"/>
    /// </summary>
    public class UcChangeTable : IUcChangeTable
    {
        /// <summary>
        /// Access to SalesManagementRepository
        /// </summary>
        private readonly ISalesManagementRepository repository;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="repository">The injected repository</param>
        public UcChangeTable(ISalesManagementRepository repository)
        {
            this.repository = repository;
        }

        public void ChangeTable(long orderId, long newTableId)
        {
            throw new NotImplementedException();
        }
    }
}
