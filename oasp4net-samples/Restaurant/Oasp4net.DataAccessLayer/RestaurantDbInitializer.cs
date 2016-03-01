using Oasp4net.DataAccessLayer.Offermanagement;
using Oasp4net.Infrastructure.DataTypes;
using System.Data.Entity;
using System.Linq;
using Oasp4net.DataAccessLayer.Offermanagement.Model;
using Oasp4net.DataAccessLayer.Tablemanagement.Model;


namespace Oasp4net.DataAccessLayer
{
    /// <summary>
    /// Database initilizer
    /// </summary>
    public class RestaurantDbInitializer : DropCreateDatabaseIfModelChanges<RestaurantContext>
    {
        /// <summary>
        /// Overrides <see cref="Seed(RestaurantContext)"/>
        /// </summary>
        /// <param name="context">Database context</param>
        protected override void Seed(RestaurantContext context)
        {
            if (!context.Products.Any())
            {
                // Drinks
                context.Drinks.Add(new Drink() { Name = "Cola", Description = "Drink Cola", IsAlcoholic = false });
                context.Drinks.Add(new Drink() { Name = "Water", Description = "Drink Water", IsAlcoholic = false });
                context.Drinks.Add(new Drink() { Name = "Wine", Description = "Drink Wine", IsAlcoholic = true });
                context.Drinks.Add(new Drink() { Name = "Beer", Description = "Drink Beer", IsAlcoholic = true });

                // Meal
                context.Meals.Add(new Meal() { Name = "Schnitzel", Description = "Schnitzel mit Pommes" });
                context.Meals.Add(new Meal() { Name = "Vegetarisch", Description = "Kartoffel-Brokoli-Auflauf" });
                context.Meals.Add(new Meal() { Name = "Vegan", Description = "Linsen Burger" });
                context.Meals.Add(new Meal() { Name = "Salat", Description = "Gemischter Salat mit Honig-Dressing" });

                // Sidedish
                context.SideDishes.Add(new SideDish() {Name = "Brot", Description = "Geröstetes Brot mit Kräuterbutter"});
                context.SideDishes.Add(new SideDish() { Name = "Kleiner Salat", Description = "Kleiner gemischter Salat" });
                context.SideDishes.Add(new SideDish() { Name = "Sprossen Salat", Description = "Veganer Salat" });
                context.SideDishes.Add(new SideDish() { Name = "Gemüse", Description = "Erbsen Wurzel Gemüse" });

                context.SaveChanges();

                //Offer
                context.Offers.Add(new Offer()
                {
                    Drink = context.Drinks.Where(d => d.Name == "Cola").FirstOrDefault(),
                    Meal = context.Meals.Where(m => m.Name == "Schnitzel").FirstOrDefault(),
                    SideDish = context.SideDishes.Where(s => s.Name == "Gemüse").FirstOrDefault(),
                    Number = 1,
                    Amount = 6.99m,
                    OfferState = OfferState.Normal
                });

                context.Offers.Add(new Offer()
                {
                    Drink = context.Drinks.Where(d => d.Name == "Water").FirstOrDefault(),
                    Meal = context.Meals.Where(m => m.Name == "Vegan").FirstOrDefault(),
                    SideDish = context.SideDishes.Where(s => s.Name == "Sprossen Salat").FirstOrDefault(),
                    Number = 2,
                    Amount = 5.99m,
                    OfferState = OfferState.Special
                });

                context.Offers.Add(new Offer()
                {
                    Drink = context.Drinks.Where(d => d.Name == "Water").FirstOrDefault(),
                    Meal = context.Meals.Where(m => m.Name == "Vegetarisch").FirstOrDefault(),
                    SideDish = context.SideDishes.Where(s => s.Name == "Kleiner Salat").FirstOrDefault(),
                    Number = 3,
                    Amount = 4.99m,
                    OfferState = OfferState.Normal
                });

                context.Offers.Add(new Offer()
                {
                    Drink = context.Drinks.Where(d => d.Name == "Wine").FirstOrDefault(),
                    Meal = context.Meals.Where(m => m.Name == "Salat").FirstOrDefault(),
                    SideDish = context.SideDishes.Where(s => s.Name == "Brot").FirstOrDefault(),
                    Number = 4,
                    Amount = 8.99m,
                    OfferState = OfferState.Normal
                });

                context.Offers.Add(new Offer()
                {
                    Drink = context.Drinks.Where(d => d.Name == "Wine").FirstOrDefault(),
                    Meal = null,
                    SideDish = null,
                    Number = 5,
                    Amount = 3.99m,
                    OfferState = OfferState.Normal
                });

                context.Offers.Add(new Offer()
                {
                    Drink = context.Drinks.Where(d => d.Name == "Beer").FirstOrDefault(),
                    Meal = null,
                    SideDish = null,
                    Number = 5,
                    Amount = 2.50m,
                    OfferState = OfferState.Normal
                });
            }

            if (!context.Tables.Any())
            {
                context.Tables.Add(new RestaurantTable
                {
                    RestaurantTableId = 1,
                    Number = 1,
                    TableState = TableState.Free,
                    WaiterId = null
                });
                context.Tables.Add(new RestaurantTable
                {
                    RestaurantTableId = 2,
                    Number = 2,
                    TableState = TableState.Free,
                    WaiterId = null
                });
                context.Tables.Add(new RestaurantTable
                {
                    RestaurantTableId = 3,
                    Number = 3,
                    TableState = TableState.Occupied,
                    WaiterId = null
                });
                context.Tables.Add(new RestaurantTable
                {
                    RestaurantTableId = 4,
                    Number = 4,
                    TableState = TableState.Free,
                    WaiterId = null
                });
                context.Tables.Add(new RestaurantTable
                {
                    RestaurantTableId = 5,
                    Number = 5,
                    TableState = TableState.Reserved,
                    WaiterId = null
                });
                context.Tables.Add(new RestaurantTable
                {
                    RestaurantTableId = 6,
                    Number = 6,
                    TableState = TableState.Free,
                    WaiterId = null
                });
                context.Tables.Add(new RestaurantTable
                {
                    RestaurantTableId = 7,
                    Number = 7,
                    TableState = TableState.Reserved,
                    WaiterId = null
                });


            }


        }
    }
}
