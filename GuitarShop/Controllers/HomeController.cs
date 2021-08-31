using Microsoft.AspNetCore.Mvc;

namespace GuitarShop.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //Navigate View Model 
            return View();
        }

        public IActionResult About()
        {
            //Navigate View Model 
            return View();
        }
    }
}