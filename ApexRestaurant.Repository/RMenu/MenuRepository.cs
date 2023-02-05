using ApexRestaurant.Repository.Domain;

namespace ApexRestaurant.Repository.RMenu
{
public class MenuRepository : GenericRepository<StaffRole>, IMenuRepository
{
public MenuRepository(RestaurantContext dbContext)
{
DbContext = dbContext;
}
}
}