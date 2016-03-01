using System;
using Oasp4net.BusinessLogicLayer.Salesmanagement.Interfaces;
using Oasp4net.DataAccessLayer.Common;
using Oasp4net.DataAccessLayer.Salesmanagement;
using Oasp4net.DataAccessLayer.Salesmanagement.Model;
using Oasp4net.Infrastructure.EntityExtensions;

namespace Oasp4net.BusinessLogicLayer.Salesmanagement.Implementation
{
    /// <summary>
    /// Implements <see cref="IUcFindOrder"/>
    /// </summary>
    public class UcFindOrder : IUcFindOrder
    {
        /// <summary>
        /// Access to SalesManagementRepository
        /// </summary>
        private readonly ISalesManagementRepository repository;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="repository">The injected repository</param>
        public UcFindOrder(ISalesManagementRepository repository)
        {
            this.repository = repository;
        }

        public SearchResponse<CompositeOrder> FindCompositeOrders(OrderSearchCriteria searchCriteria)
        {
            throw new NotImplementedException();
        }

        public Order FindOrder(long orderId)
        {
            throw new NotImplementedException();
        }

        public CompositeOrder FindOrder(Order order)
        {
            throw new NotImplementedException();
        }

        public Order FindOrderForTable(long tableId)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Implements <see cref="IUcFindOrder.FindOrders(OrderSearchCriteria)"/>
        /// </summary>
        /// <param name="searchCriteria">The given search criteria</param>
        /// <returns><see cref="SearchResponse{Order}"/></returns>
        public SearchResponse<Order> FindOrders(OrderSearchCriteria searchCriteria)
        {
            return repository.FindOrders(searchCriteria);
        }
    }
}
