using Microsoft.AspNetCore.Mvc;

namespace Vlogo.Clients.Host.Controllers
{
    public class HomeController : Controller
    {
        public HomeController()
        {

        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
    }
}
