using System;

namespace ApexRestaurant.Repository.Domain
{
    public class StaffRoles
    {
        public int Id { get; set; }

        public string StaffRoleDescription { get; set; }

        public bool IsActive { get; set; }

        public string CreatedBy { get; set; }

        public DateTime CreatedOn { get; set; }

        public string UpdatedBy { get; set; }

        public DateTime UpdatedOn { get; set; }

    }
}