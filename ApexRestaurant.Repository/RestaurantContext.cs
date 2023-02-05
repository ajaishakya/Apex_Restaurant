using Microsoft.EntityFrameworkCore;
using ApexRestaurant.Repository.Domain;

namespace ApexRestaurant.Repository
{
public class RestaurantContext : DbContext
{

public RestaurantContext(DbContextOptions<RestaurantContext> options) :
base(options)
{
}

public DbSet<StaffRole> Customers { get; set; }
public DbSet<StaffRole> Menu { get; set; }
public DbSet<StaffRole> MenuItems { get; set; }
public DbSet<Meal> Meal { get; set; }
public DbSet<StaffRole> MealDishes { get; set; }
public DbSet<StaffRole> Staff { get; set; }
public DbSet<StaffRole> StaffRole { get; set; }

protected override void OnModelCreating(ModelBuilder modelBuilder)
{
base.OnModelCreating(modelBuilder);
}

}
}