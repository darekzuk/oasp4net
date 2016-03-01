using System;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using Oasp4net.DataAccessLayer.Offermanagement;
using Oasp4net.DataAccessLayer.Offermanagement.Model;
using Oasp4net.DataAccessLayer.Tablemanagement.Model;

namespace Oasp4net.DataAccessLayer.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<Oasp4net.DataAccessLayer.RestaurantContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;      
        }

        protected override void Seed(Oasp4net.DataAccessLayer.RestaurantContext context)
        {
            if (!context.Products.Any())
            {
                context.Drinks.Add(new Drink() { Name = "Cola", Description = "Drink Cola", IsAlcoholic = false });
            }

            context.Tables.Add(new RestaurantTable { RestaurantTableId = 1, TableState = TableState.Free, WaiterId = 1 });
            context.Tables.Add(new RestaurantTable { RestaurantTableId = 2, TableState = TableState.Free, WaiterId = 2 });
            context.Tables.Add(new RestaurantTable { RestaurantTableId = 3, TableState = TableState.Free, WaiterId = 3 });
            context.Tables.Add(new RestaurantTable { RestaurantTableId = 4, TableState = TableState.Free, WaiterId = 1 });
            context.Tables.Add(new RestaurantTable { RestaurantTableId = 5, TableState = TableState.Free, WaiterId = 2 });
            context.Tables.Add(new RestaurantTable { RestaurantTableId = 6, TableState = TableState.Free, WaiterId = 3 });
            context.Tables.Add(new RestaurantTable { RestaurantTableId = 7, TableState = TableState.Free, WaiterId = 1 });


        }
    }
}
