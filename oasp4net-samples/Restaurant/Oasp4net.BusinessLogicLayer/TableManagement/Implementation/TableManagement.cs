using Oasp4net.BusinessLogicLayer.TableManagement.Interfaces;
using System.Collections.Generic;
using System;
using Oasp4net.DataAccessLayer.Tablemanagement;
using Oasp4net.DataAccessLayer.Tablemanagement.Model;
using Oasp4net.Infrastructure.EntityExtensions;

namespace Oasp4net.BusinessLogicLayer.TableManagement.Implementation
{
    /// <summary>
    /// Implements <see cref="ITableManagement"/>
    /// </summary>
    public class TableManagement : ITableManagement
    {
        /// <summary>
        /// Access to Tablemanagement Repository
        /// </summary>
        private readonly ITableManagementRepository tableManagementRepo;

        /// <summary>
        /// Construction
        /// </summary>
        /// <param name="repo">The injected Repository</param>
        public TableManagement(ITableManagementRepository repo)
        {
            tableManagementRepo = repo;
        }

        /// <summary>
        /// Implements <see cref="ITableManagement.FindAllTables"/>
        /// </summary>
        /// <returns>List of <see cref="RestaurantTable"/></returns>
        public IList<RestaurantTable> FindAllTables()
        {
            return tableManagementRepo.FindAllTables();
        }

        /// <summary>
        /// Implements <see cref="ITableManagement.FindFreeTables"/>
        /// </summary>
        /// <returns>List of <see cref="RestaurantTable"/></returns>
        public IList<RestaurantTable> FindFreeTables()
        {
            return tableManagementRepo.FindFreeTables();
        }

        /// <summary>
        /// Implements <see cref="ITableManagement.FindTable(int)"/>
        /// </summary>
        /// <param name="id"></param>
        /// <returns>The table</returns>
        public RestaurantTable FindTable(int id)
        {
            return tableManagementRepo.FindTable(id);
        }
        
        /// <summary>
        /// Implements <see cref="ITableManagementRepository.FindTables(SearchRequest)"/>
        /// </summary>
        /// <param name="searchRequest">The search request</param>
        /// <returns>Search Response</returns>
        public SearchResponse<RestaurantTable> FindTables(SearchRequest searchRequest)
        {
            return tableManagementRepo.FindTables(searchRequest);
        }

        /// <summary>
        /// Implements <see cref="ITableManagement.SaveTable(RestaurantTable)"/>
        /// </summary>
        /// <param name="table">A table to save</param>
        public void SaveTable(RestaurantTable table)
        {
            tableManagementRepo.SaveTable(table);
        }
    }
}
