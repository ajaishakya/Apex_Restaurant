using System;
using System.ComponentModel.DataAnnotations;

namespace ApexRestaurant.Repository.Domain
{
    public class MenuItems
    {
        [Key]
        public int ItemId { get; set; }
        public int MenuId { get; set; }
        public String ItemName { get; set; }

    }
}