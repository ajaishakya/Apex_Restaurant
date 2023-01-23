using ApexRestaurant.Repository.Domain;
using ApexRestaurant.Repository.RMealDishes;

namespace ApexRestaurant.Services.SMealDishes
{
public class MealDishesService : GenericService<MealDishes>, IMealDishesService
{
public MealDishesService(IMealDishesRepository mealdishesRepository) :
base(mealdishesRepository)
{

}
}
}