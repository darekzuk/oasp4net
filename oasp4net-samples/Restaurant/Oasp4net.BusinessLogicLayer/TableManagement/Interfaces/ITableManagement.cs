using Oasp4net.Infrastructure.EntityExtensions;
using System.Collections.Generic;
using Oasp4net.DataAccessLayer.Tablemanagement.Model;


namespace Oasp4net.BusinessLogicLayer.TableManagement.Interfaces
{
    /// <summary>
    /// Interface fuer TableManagement
    /// </summary>
    public interface ITableManagement
    {
        /// <summary>
        /// Returns a table by its id
        /// </summary>
        /// <param name="id">The table id</param>
        /// <returns><see cref="RestaurantTable"/></returns>
        RestaurantTable FindTable(int id);

        /// <summary>
        /// Find all tables and returns a list
        /// </summary>
        /// <returns>List of <see cref="RestaurantTable"/></returns>
        IList<RestaurantTable> FindAllTables();

        /// <summary>
        /// Returns a list of free tables
        /// </summary>
        /// <returns>List of <see cref="RestaurantTable"/></returns>
        IList<RestaurantTable> FindFreeTables();

        /// <summary>
        /// Find all tables and returns a list
        /// </summary>
        /// <returns>List of <see cref="RestaurantTable"/></returns>
        SearchResponse<RestaurantTable> FindTables(SearchRequest searchRequest);

        /// <summary>
        /// Saves or updates a table entity
        /// </summary>
        /// <param name="table">A table to save</param>
        void SaveTable(RestaurantTable table);
    }
}
