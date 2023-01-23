using ApexRestaurant.Repository.Domain;
using ApexRestaurant.Repository.RMenuItems;

namespace ApexRestaurant.Services.SMenuItems
{
public class MenuItemsService : GenericService<MenuItems>, IMenuItemsService
{
public MenuItemsService(IMenuItemsRepository menuitemsRepository) :
base(menuitemsRepository)
{

}
}
}