using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ApexRestaurant.Repository.RCustomer;
using ApexRestaurant.Repository.RMeal;
using ApexRestaurant.Repository.RMealDish;
using ApexRestaurant.Repository.RMenuItem;
using ApexRestaurant.Repository.RStaffRole;
using ApexRestaurant.Repository.RStaff;
using ApexRestaurant.Repository.RMenu;
using Pomelo.EntityFrameworkCore.MySql.Storage;

namespace ApexRestaurant.Repository
{
    public static class RepositoryModule
    {
        public static void Register(IServiceCollection services, string connection,
        string migrationsAssembly)
        {
            //services.AddDbContext<RestaurantContext>(options => options.UseMySQL(connection, builder => builder.MigrationsAssembly(migrationsAssembly)));
            services.AddDbContextPool<RestaurantContext>(options => options.UseMySql(connection));

            services.AddTransient<ICustomerRepository, CustomerRepository>();
            services.AddTransient<IMealRepository, MealRepository>();
            services.AddTransient<IMealDishRepository, MealDishRepository>();
            services.AddTransient<IMenuItemRepository, MenuItemRepository>();
            services.AddTransient<IMenuRepository, MenuRepository>();
            services.AddTransient<IStaffRepository, StaffRepository>();
            services.AddTransient<IStaffRoleRepository, StaffRoleRepository>();
        }
    }
}
