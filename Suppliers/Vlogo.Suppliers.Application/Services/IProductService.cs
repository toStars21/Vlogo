using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Vlogo.Suppliers.Contracts.Products;

namespace Vlogo.Suppliers.Application.Services
{
    public interface IProductService
    {
        Task<Product> Get(Guid id);
        Task<IReadOnlyCollection<Product>> GetAll();
        Task CreateUpdate(Product product);
        Task Delete(Guid id);
    }
}