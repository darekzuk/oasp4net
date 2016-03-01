using System;
using Oasp4net.BusinessLogicLayer.Salesmanagement.Interfaces;
using Oasp4net.DataAccessLayer.Offermanagement;
using Oasp4net.DataAccessLayer.Offermanagement.Model;
using Oasp4net.DataAccessLayer.Salesmanagement;
using Oasp4net.DataAccessLayer.Salesmanagement.Model;

namespace Oasp4net.BusinessLogicLayer.Salesmanagement.Implementation
{
    /// <summary>
    /// Impelments <see cref="IUcManageOrderPosition"/>
    /// </summary>
    public class UcManageOrderPosition : IUcManageOrderPosition
    {
        /// <summary>
        /// Access to SalesManagementRepository
        /// </summary>
        private readonly ISalesManagementRepository repository;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="repository">The injected repository</param>
        public UcManageOrderPosition(ISalesManagementRepository repository)
        {
            this.repository = repository;
        }

        public OrderPosition CreateOrderPosition(Offer offer, Order order, string comment)
        {
            throw new NotImplementedException();
        }

        public OrderPosition SaveOrderPosition(OrderPosition orderPosition)
        {
            throw new NotImplementedException();
        }
    }
}
