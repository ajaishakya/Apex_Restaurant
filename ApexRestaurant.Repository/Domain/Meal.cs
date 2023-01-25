using System;

namespace ApexRestaurant.Repository.Domain
{
public class Meal
{
public int MealId { get; set; }
public int CustomerId { get; set; }
public int StaffId { get; set; }
public DateOnly MealDate {get; set;}
public int MealCost {get; set;}

}
}
