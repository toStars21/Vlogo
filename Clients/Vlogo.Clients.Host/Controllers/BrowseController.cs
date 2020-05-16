using Microsoft.AspNetCore.Mvc;

namespace Vlogo.Clients.Host.Controllers
{
    public class BrowseController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}