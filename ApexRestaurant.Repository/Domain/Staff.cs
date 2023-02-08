using System;
using System.ComponentModel.DataAnnotations;

namespace ApexRestaurant.Repository.Domain
{
    public class Staff
    {
        [Key]
        public int StaffId { get; set; }
        public int StaffRoleCode { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }

    }
}