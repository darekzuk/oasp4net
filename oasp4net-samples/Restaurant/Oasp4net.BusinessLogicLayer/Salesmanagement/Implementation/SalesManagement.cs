using System;
using System.Collections.Generic;
using Oasp4net.BusinessLogicLayer.Salesmanagement.Interfaces;
using Oasp4net.DataAccessLayer.Common;
using Oasp4net.DataAccessLayer.Offermanagement;
using Oasp4net.DataAccessLayer.Offermanagement.Model;
using Oasp4net.DataAccessLayer.Salesmanagement;
using Oasp4net.DataAccessLayer.Salesmanagement.Model;
using Oasp4net.DataAccessLayer.Tablemanagement.Model;
using Oasp4net.Infrastructure.EntityExtensions;

namespace Oasp4net.BusinessLogicLayer.Salesmanagement.Implementation
{
    public class SalesManagement : ISalesManagement
    {
        /// <summary>
        /// The UcChangeTable
        /// </summary>
        private readonly IUcChangeTable ucChangeTable;

        /// <summary>
        /// The UcFindBill
        /// </summary>
        private readonly IUcFindBill ucFindBill;

        /// <summary>
        /// The UcFindOrder
        /// </summary>
        private readonly IUcFindOrder ucFindOrder;

        /// <summary>
        /// The UcFindOrderPosition
        /// </summary>
        private readonly IUcFindOrderPosition ucFindOrderPosition;

        /// <summary>
        /// The UcManageBill
        /// </summary>
        private readonly IUcManageBill ucManageBill;

        /// <summary>
        /// The UcManageOrder
        /// </summary>
        private readonly IUcManageOrder ucManageOrder;

        /// <summary>
        /// The UcManageOrderPosition
        /// </summary>
        private readonly IUcManageOrderPosition ucManageOrderPosition;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="ucChangeTable">Injected UcChangeTable</param>
        /// <param name="ucFindBill">Injected UcFindBill</param>
        /// <param name="ucFindOrder">Injected UcFindOrder</param>
        /// <param name="ucFindOrderPosition">Injected UcFindOrderPosition</param>
        /// <param name="ucManageBill">Injected UcManageBill</param>
        /// <param name="ucManageOrder">Injected UcManageOrder</param>
        /// <param name="ucManageOrderPosition">Injected UcManageOrderPosition</param>
        public SalesManagement(IUcChangeTable ucChangeTable, IUcFindBill ucFindBill, IUcFindOrder ucFindOrder,
                               IUcFindOrderPosition ucFindOrderPosition, IUcManageBill ucManageBill, IUcManageOrder ucManageOrder,
                               IUcManageOrderPosition ucManageOrderPosition)
        {
            this.ucChangeTable = ucChangeTable;
            this.ucFindBill = ucFindBill;
            this.ucFindOrder = ucFindOrder;
            this.ucFindOrderPosition = ucFindOrderPosition;
            this.ucManageBill = ucManageBill;
            this.ucManageOrder = ucManageOrder;
            this.ucManageOrderPosition = ucManageOrderPosition;
        }

        public void ChangeTable(long orderId, long newTableId)
        {
            ucChangeTable.ChangeTable(orderId, newTableId);
        }

        public Bill CreateBill(Bill bill)
        {
            return ucManageBill.CreateBill(bill);
        }

        public OrderPosition CreateOrderPosition(Offer offer, Order order, string comment)
        {
            throw new NotImplementedException();
        }

        public void DeleteBill(long billId)
        {
            throw new NotImplementedException();
        }

        public void DeleteOrder(long orderId)
        {
            throw new NotImplementedException();
        }

        public PaymentStatus DoPayment(Bill bill)
        {
            throw new NotImplementedException();
        }

        public CompositeBill FindBill(long billId)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Implements <see cref="IUcFindOrder.FindCompositeOrders(OrderSearchCriteria)"/>
        /// </summary>
        /// <param name="searchCriteria">The given search criteria</param>
        /// <returns><see cref="SearchResponse{CompositeOrder}"/></returns>
        public SearchResponse<CompositeOrder> FindCompositeOrders(OrderSearchCriteria searchCriteria)
        {
            var responseOrders = ucFindOrder.FindOrders(searchCriteria);
            var orders = responseOrders.Result;

            var result = new List<CompositeOrder>();
            foreach (var order in orders)
            {
                var compositeOrder = new CompositeOrder();
                compositeOrder.Order = order;
                compositeOrder.OrderPositions = FindOrderPositionsByOrderId(order.OrderId);
                result.Add(compositeOrder);
            }
            var pagination = new Pagination
            {
                Page = 1,
                Size = result.Count,
                Total = result.Count
            };

            return new SearchResponse<CompositeOrder>
            {
                Pagination = pagination,
                Result = result
            };

        }

        /// <summary>
        /// Implements <see cref="IUcFindOrderPosition.FindOrderPositionsByOrderId(long)"/>
        /// </summary>
        /// <param name="orderId">The given order id</param>
        /// <returns>List of <see cref="OrderPosition"/></returns>
        public IList<OrderPosition> FindOrderPositionsByOrderId(long orderId)
        {
            return ucFindOrderPosition.FindOrderPositionsByOrderId(orderId);
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

        public OrderPosition FindOrderPosition(long orderPositionId)
        {
            throw new NotImplementedException();
        }

        public IList<OrderPosition> FindOrderPositions(OrderPositionSearchCriteria searchCriteria)
        {
            throw new NotImplementedException();
        }

        public SearchResponse<Order> FindOrders(OrderSearchCriteria searchCriteria)
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
        /// <param name="compositeOrder">the given order and order positions</param>
        /// <returns></returns>
        public CompositeOrder SaveOrder(CompositeOrder compositeOrder)
        {
            return ucManageOrder.SaveOrder(compositeOrder);
        }

        public OrderPosition SaveOrderPosition(OrderPosition orderPosition)
        {
            throw new NotImplementedException();
        }
    }
}
