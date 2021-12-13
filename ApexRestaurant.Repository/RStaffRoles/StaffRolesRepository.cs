using ApexRestaurant.Repository.Domain;

namespace ApexRestaurant.Repository.RStaffRoles
{
    public class StaffRolesRepository : GenericRepository<StaffRoles>, IStaffRolesRepository
    {
        public StaffRolesRepository(RestaurantContext dbContext)
        {
            DbContext = dbContext;
        }
    }
}