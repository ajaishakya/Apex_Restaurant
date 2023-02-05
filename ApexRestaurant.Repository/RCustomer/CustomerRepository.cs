using ApexRestaurant.Repository.Domain;

namespace ApexRestaurant.Repository.RCustomer
{
public class CustomerRepository : GenericRepository<StaffRole>, ICustomerRepository
{
public CustomerRepository(RestaurantContext dbContext)
{
DbContext = dbContext;
}
}
}