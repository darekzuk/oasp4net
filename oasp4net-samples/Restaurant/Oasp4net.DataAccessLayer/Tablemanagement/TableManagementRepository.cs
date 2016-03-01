using System.Collections.Generic;
using System.Linq;
using Oasp4net.DataAccessLayer.Tablemanagement.Model;
using Oasp4net.Infrastructure.EntityExtensions;

namespace Oasp4net.DataAccessLayer.Tablemanagement
{
    /// <summary>
    /// Implements <see cref="ITableManagementRepository"/>
    /// </summary>
    public class TableManagementRepository : ITableManagementRepository
    {
        /// <summary>
        /// The given database context
        /// </summary>
        private readonly RestaurantContext context;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="context">Databasecontext</param>
        public TableManagementRepository(RestaurantContext context)
        {
            this.context = context;
        }

        /// <summary>
        /// Implements <see cref="ITableManagementRepository.FindAllTables"/>
        /// </summary>
        /// <returns>List of <see cref="RestaurantTable"/></returns>
        public IList<RestaurantTable> FindAllTables()
        {
            return (from t in context.Tables select t).ToList();
        }

        /// <summary>
        /// Implements <see cref="ITableManagementRepository.FindFreeTables"/>
        /// </summary>
        /// <returns>List of <see cref="RestaurantTable"/></returns>
        public IList<RestaurantTable> FindFreeTables()
        {
            return (from t in context.Tables where t.TableState == TableState.Free select t).ToList();
        }

        /// <summary>
        /// Implements <see cref="ITableManagementRepository.FindTable(int)"/>
        /// </summary>
        /// <param name="id"></param>
        /// <returns>A RestaurantTable</returns>
        public RestaurantTable FindTable(int id)
        {
            return (from t in context.Tables where t.RestaurantTableId == id select t).FirstOrDefault();
        }

        /// <summary>
        /// Implements <see cref="ITableManagementRepository.FindTables(SearchRequest)"/>
        /// </summary>
        /// <param name="searchRequest">The search request</param>
        /// <returns><see cref="SearchResponse{RestaurantTable}"/></returns>
        public SearchResponse<RestaurantTable> FindTables(SearchRequest searchRequest)
        {
            var pagination = searchRequest.Pagination;
            int skip = pagination.Page <= 0 ? 0 : (pagination.Page - 1) * pagination.Size;
            pagination.Total = context.Tables.Count();
            
            var tables = new List<RestaurantTable>();
            if (pagination.Total > 0)
            {
                tables = (from t in context.Tables orderby t.RestaurantTableId select t).Skip(skip).Take(pagination.Size).ToList();
            }

            return new SearchResponse<RestaurantTable>
            {
                Pagination = pagination,
                Result = tables
            };
        }

        /// <summary>
        /// Implements <see cref="ITableManagementRepository.SaveTable(RestaurantTable)"/>
        /// </summary>
        /// <param name="table">A table to save</param>
        public void SaveTable(RestaurantTable table)
        {
            var actualTable = (from t in context.Tables where (t.RestaurantTableId == table.RestaurantTableId) select t).FirstOrDefault();
            if (actualTable != null)
            {
                actualTable.TableState = table.TableState;
                actualTable.WaiterId = table.WaiterId;
                actualTable.Number = table.Number;
            }
            context.SaveChanges();        
        }

    }
}
