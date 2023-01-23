using System;

namespace ApexRestaurant.Repository.Domain
{
public class Menu
{
    public int MenuId { get; set; }
    public String MenuName { get; set; }
    public DateOnly DateFrom {get; set;}
    public DateOnly DateTo {get; set;}

}
}
