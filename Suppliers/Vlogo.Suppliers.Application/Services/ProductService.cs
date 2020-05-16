using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Vlogo.Suppliers.Application.Repositories;
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

        public Task<Product> Get(Guid id)
        {
            return _repository.Get(id);
        }

        public Task<IReadOnlyCollection<Product>> GetAll()
        {
            return _repository.GetAll();
        }

        public Task CreateUpdate(Product product)
        {
            return _repository.CreateUpdate(product);
        }

        public Task Delete(Guid id)
        {
            return _repository.Delete(id);
        }
    }
}