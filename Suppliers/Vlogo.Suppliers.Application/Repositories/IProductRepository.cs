using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Vlogo.Suppliers.Contracts.Products;

namespace Vlogo.Suppliers.Application.Repositories
{
    public interface IProductRepository
    {
        Task<Product> Get(Guid id);
        Task<IReadOnlyCollection<Product>> GetAll();
        Task CreateUpdate(Product product);
        Task Delete(Guid id);
    }
}
