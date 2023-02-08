using System;
using System.ComponentModel.DataAnnotations;

namespace ApexRestaurant.Repository.Domain
{
    public class Meal
    {
        [Key]
        public int MealId { get; set; }
        public int CustomerId { get; set; }
        public int StaffId { get; set; }
        public DateTime MealDate { get; set; }
        public int MealCost { get; set; }

    }
}
