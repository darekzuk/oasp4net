using System.Web.Http;
using Oasp4net.BusinessLogicLayer.TableManagement.Interfaces;
using Oasp4net.Infrastructure.EntityExtensions;
using Oasp4net.ServiceLayer.Api.Model.TableManagement;
using System.Linq;
using Oasp4net.DataAccessLayer.Tablemanagement.Model;

namespace Oasp4net.ServiceLayer.Api
{
    //[Authorize]
    public class TableManagementController : RestaurantController
    {
        public ITableManagement tableManagement;
        
        public TableManagementController(ITableManagement tableManagement) : base()
        {
            this.tableManagement = tableManagement;
        }

        [HttpGet]
        [Route("oasp4j-sample-server/services/rest/tablemanagement/v1/table/{tableId}")]
        public IHttpActionResult FindTable(int tableId)
        {
            var table = tableManagement.FindTable(tableId); 
            if (table != null)
            {
                return Ok(AutoMapper.Mapper.Map<RestaurantTableEntity>(table));
            }

            return NotFound();           
        }


        [HttpPost]
        [Route("oasp4j-sample-server/services/rest/tablemanagement/v1/table/search")]        
        public SearchResponse<RestaurantTableEntity> Search(SearchRequest request)
        {
            SearchResponse<RestaurantTable> tables = tableManagement.FindTables(request);

            var result =  new SearchResponse<RestaurantTableEntity>
            {
                Result = tables.Result.Select(t => AutoMapper.Mapper.Map<RestaurantTableEntity>(t)).ToList(),
                Pagination = tables.Pagination
            };

            return result;                      
        }

        [HttpPost]
        [Route("oasp4j-sample-server/services/rest/tablemanagement/v1/table")]        
        public void SaveTable(RestaurantTableEntity tableEntity)
        {
            if (tableEntity != null)
            {
                var table = AutoMapper.Mapper.Map<RestaurantTable>(tableEntity);
                if (table != null)
                {
                    tableManagement.SaveTable(table);
                }
            }

            
        }
    }
}
