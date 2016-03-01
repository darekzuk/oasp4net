using System.Collections.Generic;
using System.Linq;
using Oasp4net.DataAccessLayer.Common;
using Oasp4net.DataAccessLayer.Salesmanagement.Model;
using Oasp4net.Infrastructure.EntityExtensions;

namespace Oasp4net.DataAccessLayer.Salesmanagement
{
    /// <summary>
    /// Implements <see cref="ISalesManagementRepository"/>
    /// </summary>
    public class SalesManagementRepository : ISalesManagementRepository
    {
        /// <summary>
        /// The given database context
        /// </summary>
        private readonly RestaurantContext context;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="context">Databasecontext</param>
        public SalesManagementRepository(RestaurantContext context)
        {
            this.context = context;
        }

        /// <summary>
        /// Find orders and order positions by the given search criteria
        /// </summary>
        /// <param name="searchCriteria">The search criteria</param>
        /// <returns>List of <see cref="CompositeOrder"/> objects</returns>
        public SearchResponse<CompositeOrder> FindCompositeOrders(OrderSearchCriteria searchCriteria)
        {

            //pagination.Total = context.Tables.Count();

            //var tables = new List<RestaurantTable>();
            //if (pagination.Total > 0)
            //{
            //    tables = (from t in context.Tables orderby t.RestaurantTableId select t).Skip(skip).Take(pagination.Size).ToList();
            //}

            //return new SearchResponse<RestaurantTable>
            //{
            //    Pagination = pagination,
            //    Result = tables
            //};
            return new SearchResponse<CompositeOrder>();
        }

        /// <summary>
        /// Implements <see cref="ISalesManagementRepository.FindOrders(OrderSearchCriteria)"/>
        /// </summary>
        /// <param name="searchCriteria">Search Criteria</param>
        /// <returns>List of <see cref="Order"/> objects</returns>
        public SearchResponse<Order> FindOrders(OrderSearchCriteria searchCriteria)
        {
            var orders = (from o in context.Orders where o.RestaurantTableId == searchCriteria.TableId && o.OrderState == searchCriteria.OrderState select o).ToList();

            var total = orders.Count();
            var pagination = new Pagination
            {
                Page = 1,
                Size = total,
                Total = total
            };

            return new SearchResponse<Order>
            {
                Pagination = pagination,
                Result = orders
            };
        }

        /// <summary>
        /// Implements <see cref="ISalesManagementRepository.FindOrderPositionsByOrderId(long)"/>
        /// </summary>
        /// <param name="orderId">The given order id</param>
        /// <returns>A list of <see cref="OrderPosition"/></returns>
        public IList<OrderPosition> FindOrderPositionsByOrderId(long orderId)
        {
            var query = (from orderPosition in context.OrderPositions select orderPosition);
            query = query.Where(op => op.OrderId == orderId);            

            return query.ToList();
        }

        /// <summary>
        /// IMplements <see cref="ISalesManagementRepository.SaveOrder(CompositeOrder)"/>
        /// </summary>
        /// <param name="">The composite order</param>
        /// <returns>The persisted composite order</returns>
        public CompositeOrder SaveOrder(CompositeOrder compositeOrder)
        {
            Order actualOrder;
            if (compositeOrder.Order.OrderId > 0)
            {
                // Update Order
                actualOrder = context.Orders.Find(compositeOrder.Order.OrderId);
                context.Entry(actualOrder).CurrentValues.SetValues(compositeOrder.Order);
            }
            else
            {
                // Create order
                actualOrder = context.Orders.Add(compositeOrder.Order);
            }            
            context.SaveChanges();

            // Update Create
            foreach (var orderPosition in compositeOrder.OrderPositions)
            {
                if (orderPosition.OrderPositionId > 0)
                {
                    // Update order position
                    var actualOrderPosition = context.OrderPositions.Find(orderPosition.OrderPositionId);
                    context.Entry(actualOrderPosition).CurrentValues.SetValues(orderPosition);
                }
                else
                {
                    // Create order position
                    orderPosition.OrderId = actualOrder.OrderId;
                    context.OrderPositions.Add(orderPosition);
                }                
            }

            var orderPositionsForOrder = FindOrderPositionsByOrderId(actualOrder.OrderId);
            // mark removed orderpositions as cancelled
            foreach (var orderPosition in orderPositionsForOrder)
            {
                var foundOrderPosition = (from op in compositeOrder.OrderPositions where orderPosition.OrderPositionId == op.OrderPositionId select op).FirstOrDefault();
                if (foundOrderPosition == null)
                {
                    orderPosition.OrderPostionState = OrderPositionState.Cancelled;
                }
            }
            context.SaveChanges();

            var result = new CompositeOrder();
            result.OrderPositions = orderPositionsForOrder;
            result.Order = actualOrder;

            return result;
        }
    }
}
