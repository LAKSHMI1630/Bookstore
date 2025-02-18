using Microsoft.AspNetCore.Mvc;

namespace BookStrore.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
