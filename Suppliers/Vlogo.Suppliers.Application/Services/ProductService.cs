using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Vlogo.Suppliers.Application.Repositories;
using Vlogo.Suppliers.Contracts;
using Vlogo.Suppliers.Contracts.Products;

namespace Vlogo.Suppliers.Application.Services
{
    internal class ProductService : IProductService
    {
        private readonly IProductRepository _repository;

        public ProductService(IProductRepository repository)
        {
            _repository = repository;
        }

        public Task<Product> Get(Guid id) => _repository.Get(id);

        public Task<IReadOnlyCollection<Product>> GetAll() => _repository.GetAll();
        public Task CreateUpdate(Product product) => _repository.CreateUpdate(product);
        public Task Delete(Guid id) => _repository.Delete(id);
    }
}
