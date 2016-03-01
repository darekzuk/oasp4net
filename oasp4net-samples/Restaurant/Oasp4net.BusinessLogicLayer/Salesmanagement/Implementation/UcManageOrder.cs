using System;
using Oasp4net.BusinessLogicLayer.Salesmanagement.Interfaces;
using Oasp4net.DataAccessLayer.Salesmanagement;
using Oasp4net.DataAccessLayer.Salesmanagement.Model;
using Oasp4net.DataAccessLayer.Tablemanagement.Model;

namespace Oasp4net.BusinessLogicLayer.Salesmanagement.Implementation
{
    /// <summary>
    /// Implements <see cref="IUcManageOrder"/>
    /// </summary>
    public class UcManageOrder : IUcManageOrder
    {
        /// <summary>
        /// Access to SalesManagementRepository
        /// </summary>
        private readonly ISalesManagementRepository repository;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="repository">The injected repository</param>
        public UcManageOrder
            (ISalesManagementRepository repository)
        {
            this.repository = repository;
        }

        public void DeleteOrder(long orderId)
        {
            throw new NotImplementedException();
        }

        public Order SaveOrder(RestaurantTable table)
        {
            throw new NotImplementedException();
        }

        public Order SaveOrder(Order order)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Implements <see cref="IUcManageOrder.SaveOrder(CompositeOrder)"/>
        /// </summary>
        /// <param name="compositeOrder">The given composite order</param>
        /// <returns>The persisted composite order</returns>
        public CompositeOrder SaveOrder(CompositeOrder compositeOrder)
        {
            return repository.SaveOrder(compositeOrder);
        }
    }
}