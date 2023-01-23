using Microsoft.Extensions.DependencyInjection;
using ApexRestaurant.Services.SCustomer;
using ApexRestaurant.Services.SMenu;
using ApexRestaurant.Services.SMenuItems;
using ApexRestaurant.Services.SMeal;
using ApexRestaurant.Services.SMealDishes;
using ApexRestaurant.Services.SStaff;

namespace ApexRestaurant.Services
{
public static class ServicesModule
{
public static void Register(IServiceCollection services)
{
services.AddTransient<ICustomerService, CustomerService>();
services.AddTransient<IMenuService, MenuService>();
services.AddTransient<IMenuItemsService, MenuItemsService>();
services.AddTransient<IMealService, MealService>();
services.AddTransient<IMealDishesService, MealDishesService>();
services.AddTransient<IStaffService, StaffService>();
// services.AddTransient<IStaffRoleService, StaffRoleService>();
}
}
}