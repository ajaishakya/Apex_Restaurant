using ApexRestaurant.Repository.Domain;

namespace ApexRestaurant.Repository.RMealDishes
{
public class MealDishesRepository : GenericRepository<MealDishes>, IMealDishesRepository
{
public MealDishesRepository(RestaurantContext dbContext)
{
DbContext = dbContext;
}
}
}