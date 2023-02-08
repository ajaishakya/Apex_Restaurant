using System;
using System.ComponentModel.DataAnnotations;

namespace ApexRestaurant.Repository.Domain
{
public class Menu
{
    [Key]
    public int MenuId { get; set; }
    public String MenuName { get; set; }
    public DateTime DateFrom {get; set;}
    public DateTime DateTo {get; set;}

}
}
