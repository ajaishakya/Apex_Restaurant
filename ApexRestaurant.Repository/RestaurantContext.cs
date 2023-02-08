using Microsoft.EntityFrameworkCore;
using ApexRestaurant.Repository.Domain;

namespace ApexRestaurant.Repository
{
    public class RestaurantContext : DbContext
    {

        public RestaurantContext(DbContextOptions<RestaurantContext> options) : base(options)
        {
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Menu> Menu { get; set; }
        public DbSet<MenuItems> MenuItems { get; set; }
        public DbSet<Meal> Meal { get; set; }
        public DbSet<MealDishes> MealDishes { get; set; }
        public DbSet<Staff> Staff { get; set; }
        public DbSet<StaffRole> StaffRole { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

    }
}