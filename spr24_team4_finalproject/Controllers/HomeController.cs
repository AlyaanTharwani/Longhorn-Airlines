using Microsoft.AspNetCore.Mvc;

namespace spr24_team4_finalproject.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
