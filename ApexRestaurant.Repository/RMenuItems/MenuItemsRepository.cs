using ApexRestaurant.Repository.Domain;

namespace ApexRestaurant.Repository.RMenuItems
{
public class MenuItemsRepository : GenericRepository<MenuItems>, IMenuItemsRepository
{
public MenuItemsRepository(RestaurantContext dbContext)
{
DbContext = dbContext;
}
}
}