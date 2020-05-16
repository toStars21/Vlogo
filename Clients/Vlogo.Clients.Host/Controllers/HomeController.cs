using Microsoft.AspNetCore.Mvc;

namespace Vlogo.Clients.Host.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
    }
}