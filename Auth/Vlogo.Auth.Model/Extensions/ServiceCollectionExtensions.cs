using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Vlogo.Auth.Model.Context;
using Vlogo.Auth.Model.Model;

namespace Vlogo.Auth.Model.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddDeliveryAuth(this IServiceCollection serviceCollection,
            string connectionString)
        {
            serviceCollection.AddDbContext<ApplicationContext>(options =>
                options.UseSqlServer(connectionString));

            serviceCollection.AddIdentity<User, IdentityRole>()
                .AddEntityFrameworkStores<ApplicationContext>();

            return serviceCollection;
        }
    }
}