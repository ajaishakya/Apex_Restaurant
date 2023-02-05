using ApexRestaurant.Repository.Domain;

namespace ApexRestaurant.Repository.RMenuItems
{
public class MenuItemsRepository : GenericRepository<StaffRole>, IMenuItemsRepository
{
public MenuItemsRepository(RestaurantContext dbContext)
{
DbContext = dbContext;
}
}
}