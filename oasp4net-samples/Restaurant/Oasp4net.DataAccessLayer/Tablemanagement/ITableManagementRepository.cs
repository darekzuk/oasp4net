using System.Collections.Generic;
using Oasp4net.DataAccessLayer.Tablemanagement.Model;
using Oasp4net.Infrastructure.EntityExtensions;

namespace Oasp4net.DataAccessLayer.Tablemanagement
{
    /// <summary>
    ///  A repository to query <see cref="RestaurantTable"/> entities.
    /// </summary>
    public interface ITableManagementRepository
    {
        /// <summary>
        /// Loads all Tables
        /// </summary>
        /// <returns>List of <see cref="RestaurantTable"/></returns>
        IList<RestaurantTable> FindAllTables();


        /// <summary>
        /// Loads all free Tables
        /// </summary>
        /// <returns>List of <see cref="RestaurantTable"/></returns>
        IList<RestaurantTable> FindFreeTables();

        /// <summary>
        /// Loads a special table with id
        /// </summary>
        /// <param name="id">The table id
        /// <returns>A <see cref="RestaurantTable"/></returns>
        RestaurantTable FindTable(int id);

        /// <summary>
        /// Loads tables which satisfy the search request
        /// </summary>
        /// <param name="searchRequest"></param>
        /// <returns></returns>
        SearchResponse<RestaurantTable> FindTables(SearchRequest searchRequest);

        /// <summary>
        /// Saves or updates a table entity
        /// </summary>
        /// <param name="table">A table to save</param>
        void SaveTable(RestaurantTable table);
    }
}
