using Microsoft.AspNetCore.Mvc;

namespace GuitarShop.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //Navigate View Model to Home/Index.cshtml
            return View();
        }

        public IActionResult About()
        {
            //Navigate View Model to Home/About.cshtml
            return View();
        }
    }
}