using Microsoft.AspNetCore.Mvc;

namespace ViewsApp.controller
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public string Details(string name)
        {
            return name;
        }
    }
}
