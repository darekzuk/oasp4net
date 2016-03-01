using System.Data.Entity;
using Oasp4net.DataAccessLayer.Offermanagement;
using Oasp4net.DataAccessLayer.Offermanagement.Model;
using Oasp4net.DataAccessLayer.Salesmanagement;
using Oasp4net.DataAccessLayer.Salesmanagement.Model;
using Oasp4net.DataAccessLayer.Tablemanagement.Model;

namespace Oasp4net.DataAccessLayer
{
    /// <summary>
    /// Database context class
    /// </summary>
    public class RestaurantContext : DbContext
    {
        /// <summary>
        /// Construction
        /// </summary>
        public RestaurantContext() : base()
        { }
        /// <summary>
        /// Access to table Drink
        /// </summary>
        public virtual DbSet<Drink> Drinks { get; set; }

        /// <summary>
        /// Access to table Product
        /// </summary>
        public virtual DbSet<Product> Products { get; set; }

        /// <summary>
        /// Access to table Offers
        /// </summary>
        public virtual DbSet<Offer> Offers { get; set; }

        /// <summary>
        /// Access to table Meals
        /// </summary>
        public virtual DbSet<Meal> Meals { get; set; }

        /// <summary>
        /// Access to table Sidedishes
        /// </summary>
        public virtual DbSet<SideDish> SideDishes { get; set; }

        /// <summary>
        /// Access to table RestaurantTable
        /// </summary>
        public virtual DbSet<RestaurantTable> Tables { get; set; }

        /// <summary>
        /// Access to table bills table
        /// </summary>
        public virtual DbSet<Bill> Bills { get; set; }

        /// <summary>
        /// Access to table orders table
        /// </summary>
        public virtual DbSet<Order> Orders { get; set; }

        /// <summary>
        /// Access to table orderpositions table
        /// </summary>
        public virtual DbSet<OrderPosition> OrderPositions { get; set; }

        public static void Configure()
        {
            Database.SetInitializer(new
              RestaurantDbInitializer());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        

    }
}
