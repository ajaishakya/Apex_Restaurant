using ApexRestaurant.Repository.Domain;

namespace ApexRestaurant.Repository.RStaff
{
public class StaffRepository : GenericRepository<StaffRole>, IStaffRepository
{
public StaffRepository(RestaurantContext dbContext)
{
DbContext = dbContext;
}
}
}