using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Vlogo.Auth.Model.Context;

namespace Vlogo.Auth.Host.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationContext _applicationContext;

        public HomeController(ApplicationContext applicationContext)
        {
            _applicationContext = applicationContext;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult ListUsers()
        {
            var users = _applicationContext.Users.ToList();
            return View(users);
        }
    }
}