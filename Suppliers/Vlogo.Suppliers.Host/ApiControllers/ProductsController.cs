//using System;
//using System.Collections.Generic;
//using System.Threading.Tasks;
//using Microsoft.AspNetCore.Mvc;
//using Vlogo.Suppliers.Application.Services;
//using Vlogo.Suppliers.Contracts.Products;

//namespace Vlogo.Suppliers.Host.ApiControllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class ProductsController : ControllerBase
//    {
//        private readonly IProductService _services;

//        public ProductsController(IProductService services)
//        {
//            _services = services;
//        }

//        [HttpGet]
//        public Task<IReadOnlyCollection<Product>> GetAll()
//        {
//            return _services.GetAll();
//        }

//        [HttpGet("{id:guid}", Name = "Get")]
//        public Task<Product> Get(Guid id)
//        {
//            return _services.Get(id);
//        }

//        [HttpPost]
//        public Task CreateUpdate([FromBody] Product product)
//        {
//            return _services.CreateUpdate(product);
//        }

//        [HttpDelete("{id:guid}")]
//        public Task Delete(Guid id)
//        {
//            return _services.Delete(id);
//        }
//    }
//}
