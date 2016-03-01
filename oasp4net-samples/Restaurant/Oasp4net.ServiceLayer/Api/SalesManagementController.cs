using Oasp4net.BusinessLogicLayer.Salesmanagement.Interfaces;
using Oasp4net.DataAccessLayer.Common;
using Oasp4net.Infrastructure.EntityExtensions;
using Oasp4net.ServiceLayer.Api.Model.SalesManagement;
using System.Linq;
using System.Web.Http;
using Oasp4net.DataAccessLayer.Salesmanagement.Model;

namespace Oasp4net.ServiceLayer.Api
{
    /// <summary>
    /// RESTful services for sales management
    /// </summary>
    public class SalesManagementController : RestaurantController
    {
        /// <summary>
        /// Sales Management Interface
        /// </summary>
        public ISalesManagement salesManagement;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="salesManagement">Injected <see cref="ISalesManagement"/></param>
        public SalesManagementController(ISalesManagement salesManagement) : base()
        {
            this.salesManagement = salesManagement;
        }

        [HttpPost]
        [Route("oasp4j-sample-server/services/rest/salesmanagement/v1/order/search")]
        public SearchResponse<CompositeOrderEntity> FindOrdersByCreteria(OrderSearchCriteria searchCriteria)
        {
            var compositeOrders =  salesManagement.FindCompositeOrders(searchCriteria);
            var result = new SearchResponse<CompositeOrderEntity>
            {
                Result = compositeOrders.Result.Select(c => AutoMapper.Mapper.Map<CompositeOrderEntity>(c)).ToList(),
                Pagination = compositeOrders.Pagination
            };

            return result;
        }

        [HttpPost]
        [Route("oasp4j-sample-server/services/rest/salesmanagement/v1/order")]
        public CompositeOrderEntity SaveOrder(CompositeOrderEntity compositeOrderEntity)
        {
            var compositeOrder = AutoMapper.Mapper.Map<CompositeOrder>(compositeOrderEntity);

            var result = salesManagement.SaveOrder(compositeOrder);

            return AutoMapper.Mapper.Map<CompositeOrderEntity>(result);
        }

        [HttpPut]
        [Route("oasp4j-sample-server/services/rest/salesmanagement/v1/order/{orderId}")]
        public CompositeOrderEntity UpdateOrder(CompositeOrderEntity compositeOrderEntity, long orderId)
        {
            var compositeOrder = AutoMapper.Mapper.Map<CompositeOrder>(compositeOrderEntity);

            var result = salesManagement.SaveOrder(compositeOrder);

            return AutoMapper.Mapper.Map<CompositeOrderEntity>(result);
        }
    }
}
