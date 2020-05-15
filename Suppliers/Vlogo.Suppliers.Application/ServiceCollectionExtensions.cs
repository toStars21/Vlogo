using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MongoDB.Driver;
using Vlogo.Suppliers.Application.Repositories;
using Vlogo.Suppliers.Application.Repositories.Mongo;
using Vlogo.Suppliers.Application.Services;
using Vlogo.Suppliers.Application.Settings;

namespace Vlogo.Suppliers.Application
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddSuppliersApplication(this IServiceCollection services)
        {
            return services
                .AddSuppliersSettings()
                .AddMongo()
                .AddMongoRepositories()
                .AddServices();
        }

        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddScoped<IProductService, ProductService>();

            return services;
        }

        public static IServiceCollection AddMongo(this IServiceCollection services)
        {
            services.AddSingleton<IMongoClient>(provider =>
            {
                var settings = provider.GetRequiredService<SuppliersSettings>();
                return new MongoClient(settings.MongoConnectionString);
            });

            return services;
        }

        public static IServiceCollection AddMongoRepositories(this IServiceCollection services)
        {
            services.AddScoped<IProductRepository, MongoProductRepository>();

            return services;
        }

        public static IServiceCollection AddSuppliersSettings(this IServiceCollection services)
        {
            services.AddSingleton(provider =>
            {
                var config = provider.GetRequiredService<IConfiguration>();

                return config.GetSection("Suppliers").Get<SuppliersSettings>();
            });

            return services;
        }
    }
}
