using System;
using System.ComponentModel.DataAnnotations;

namespace ApexRestaurant.Repository.Domain
{
    public class MealDishes
    {
        [Key]
        public int MealDishesId { get; set; }
        public int ItemId { get; set; }
        public int Quantity { get; set; }
    }
}