using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Vlogo.Suppliers.Application.Services;
using Vlogo.Suppliers.Contracts.Products;

namespace Vlogo.Suppliers.Host.Controllers
{
    [Route("[controller]")]
    public class ProductsController : Controller
    {
        private readonly IProductService _services;

        public ProductsController(IProductService services)
        {
            _services = services;
        }

        [HttpGet]
        public async Task<IActionResult> All()
        {
            var all = await _services.GetAll();

            return View(all);
        }

        // GET: Products/Details/5
        [HttpGet("details/{id}")]
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Products/Create
        [HttpGet("create")]
        public ActionResult Create()
        {
            return View();
        }

        // POST: Products/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(All));
            }
            catch
            {
                return View();
            }
        }

        [HttpGet("edit/{id:guid}")]
        public async Task<ActionResult> Edit(Guid id)
        {
            var product = await _services.Get(id);

            return View(product);
        }

        [HttpPost("edit/{id:guid}")]
        public ActionResult Edit(Guid id, Product product)
        {
            return RedirectToAction(nameof(All));
        }

        // GET: Products/Delete/5
        [HttpDelete]
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Products/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(All));
            }
            catch
            {
                return View();
            }
        }
    }
}