using Microsoft.AspNetCore.Mvc;

namespace templetApp.controller
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //ViewData work as a dictionary KEY VALUE Pair
            ViewData["name"] = "Hello From Testing ViewData";
            ViewData["date"] = DateTime.Now;

            string[] fruits = { "Apple", "Mango", "Banan", "Orange", "Grapes" };
            ViewData["fruitList"] = fruits;
            return View();
        }

        public IActionResult About()
        {
            //ViewBag work as a Class
            ViewBag.details = "This is the intro Application.";
            string[] students = { "Faizan", "Ali", "Yawar" };
            ViewBag.stds = students;
            return View();
        }

        public IActionResult Contact()
        {
            TempData["city"] = "Karachi";
            TempData["phone"] = "021-33448894";
                return View();
        }

        public IActionResult FormSubmit()
        {
            TempData["status"] = true;
            return RedirectToAction("Students");
        }

        public IActionResult Students()
        {
            return View();
        }
    }
}
