using System;
using System.Collections.Generic;
using Oasp4net.BusinessLogicLayer.Salesmanagement.Interfaces;
using Oasp4net.DataAccessLayer.Common;
using Oasp4net.DataAccessLayer.Salesmanagement;
using Oasp4net.DataAccessLayer.Salesmanagement.Model;

namespace Oasp4net.BusinessLogicLayer.Salesmanagement.Implementation
{
    /// <summary>
    /// Implements <see cref="IUcFindOrderPosition"/>
    /// </summary>
    public class UcFindOrderPosition : IUcFindOrderPosition
    {
        /// <summary>
        /// Access to SalesManagementRepository
        /// </summary>
        private readonly ISalesManagementRepository repository;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="repository">The injected repository</param>
        public UcFindOrderPosition(ISalesManagementRepository repository)
        {
            this.repository = repository;
        }

        public IList<OrderPosition> FindOrderPositionsByOrderId(long orderId)
        {
            return repository.FindOrderPositionsByOrderId(orderId);
        }

        public OrderPosition FindOrderPosition(long orderPositionId)
        {
            throw new NotImplementedException();
        }

        public IList<OrderPosition> FindOrderPositions(OrderPositionSearchCriteria searchCriteria)
        {
            throw new NotImplementedException();
        }
    }
}
