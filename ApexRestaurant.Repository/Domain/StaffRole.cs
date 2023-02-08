using System;
using System.ComponentModel.DataAnnotations;

namespace ApexRestaurant.Repository.Domain
{
    public class StaffRole
    {
        [Key]
        public int StaffRoleId { get; set; }
        public string Description { get; set; }

    }
}