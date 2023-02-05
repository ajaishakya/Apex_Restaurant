using ApexRestaurant.Repository.Domain;

namespace ApexRestaurant.Repository.RMealDishes
{
public class MealDishesRepository : GenericRepository<StaffRole>, IMealDishesRepository
{
public MealDishesRepository(RestaurantContext dbContext)
{
DbContext = dbContext;
}
}
}