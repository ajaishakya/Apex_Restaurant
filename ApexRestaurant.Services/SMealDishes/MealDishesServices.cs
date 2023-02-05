using ApexRestaurant.Repository.Domain;
using ApexRestaurant.Repository.RMealDishes;

namespace ApexRestaurant.Services.SMealDishes
{
public class MealDishesService : GenericService<StaffRole>, IMealDishesService
{
public MealDishesService(IMealDishesRepository mealdishesRepository) :
base(mealdishesRepository)
{

}
}
}