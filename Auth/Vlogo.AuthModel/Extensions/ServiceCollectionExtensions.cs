using Delivery.AuthModel.Context;
using Delivery.AuthModel.Model;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Delivery.AuthModel.Extensions
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