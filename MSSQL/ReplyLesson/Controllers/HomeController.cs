using Microsoft.AspNetCore.Mvc;

namespace EmptyProject.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewData["name"] = "Ceyhun";
            int num = 19;
            return View(num);
        }
        public IActionResult Contact()
        {
            ViewBag.age = 19;
            string name = "Ceyhun";
            return View((object)name);
        }
    }
}
