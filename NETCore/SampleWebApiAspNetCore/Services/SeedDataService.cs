using SampleWebApiAspNetCore.Entities;
using SampleWebApiAspNetCore.Repositories;

namespace SampleWebApiAspNetCore.Services
{
    public class SeedDataService : ISeedDataService
    {
        public void Initialize(FoodDbContext foodContext, DrinkDbContext drinksContext)
        {
            foodContext.FoodItems.Add(new FoodEntity() { Calories = 1000, Type = "Starter", Name = "Lasagne", Created = DateTime.Now });
            foodContext.FoodItems.Add(new FoodEntity() { Calories = 1100, Type = "Main", Name = "Hamburger", Created = DateTime.Now });
            foodContext.FoodItems.Add(new FoodEntity() { Calories = 1200, Type = "Dessert", Name = "Spaghetti", Created = DateTime.Now });
            foodContext.FoodItems.Add(new FoodEntity() { Calories = 1300, Type = "Starter", Name = "Pizza", Created = DateTime.Now });

            foodContext.SaveChanges();

            drinksContext.DrinkItems.Add(new DrinkEntity() { Calories = 0, Type = "S+", Name = "Water", Created = DateTime.Now });
            drinksContext.DrinkItems.Add(new DrinkEntity() { Calories = 45, Type = "A+", Name = "Orange Juice", Created = DateTime.Now });
            drinksContext.DrinkItems.Add(new DrinkEntity() { Calories = 143, Type = "C-", Name = "Mojito", Created = DateTime.Now });
            drinksContext.DrinkItems.Add(new DrinkEntity() { Calories = 240, Type = "D-", Name = "Coke", Created = DateTime.Now });

            drinksContext.SaveChanges();
        }
    }
}
