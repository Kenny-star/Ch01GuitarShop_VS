using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using GuitarShop.Models;

namespace GuitarShop.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Detail(string id)
        {
            //Get every productId from the Database to send as a Response view.
            Product product = DB.GetProduct(id);
            return View(product);
        }

        public IActionResult List()
        {
            //Get every products from the Database to send as a Response view.
            List<Product> products = DB.GetProducts();
            return View(products);
        }
    }
}