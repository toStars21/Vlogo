using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MongoDB.Driver;
using Vlogo.Suppliers.Application.Settings;
using Vlogo.Suppliers.Contracts.Products;

namespace Vlogo.Suppliers.Application.Repositories.Mongo
{
    internal class MongoProductRepository : IProductRepository
    {
        private readonly IMongoDatabase _db;
        private readonly SuppliersSettings _settings;

        public MongoProductRepository(IMongoClient client, SuppliersSettings settings)
        {
            _settings = settings;

            _db = client.GetDatabase(settings.SuppliersDbName);
        }

        public Task<Product> Get(Guid id)
        {
            var collection = GetCollection();

            return collection
                .Find(commodity => commodity.Id == id)
                .FirstOrDefaultAsync();
        }

        public async Task<IReadOnlyCollection<Product>> GetAll()
        {
            var collection = GetCollection();

            var all = await collection.Find(FilterDefinition<Product>.Empty).ToListAsync();

            return all;
        }

        public Task CreateUpdate(Product product)
        {
            var collection = GetCollection();

            return collection.FindOneAndReplaceAsync(
                new FilterDefinitionBuilder<Product>().Eq(c => c.Id, product.Id),
                product,
                new FindOneAndReplaceOptions<Product, Product>
                {
                    IsUpsert = true
                });
        }

        public Task Delete(Guid id)
        {
            var collection = GetCollection();

            return collection.FindOneAndDeleteAsync(commodity => commodity.Id == id);
        }

        private IMongoCollection<Product> GetCollection()
        {
            return _db.GetCollection<Product>(_settings.ProductsCollectionName);
        }
    }
}