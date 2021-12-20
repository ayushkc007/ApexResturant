using ApexRestaurant.Repository.Domain;

namespace ApexRestaurant.Repository.RStaffRole
{
    public class StaffRolesRepository : GenericRepository<StaffRole>, IStaffRoleRepository
    {
        public StaffRolesRepository(RestaurantContext dbContext)
        {
            DbContext = dbContext;
        }
    }
}