using Microsoft.AspNetCore.Mvc;

namespace introApp.Controllers
{
    public class HomeController : Controller
    {
        //public string Index() {
        //    return "Index From Controller";
        //  }

        //public string Gallery()
        //{
        //    return "Gallery From Controller";
        //}

        //public int Year()
        //{
        //    return 2025;
        //}

      public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Services()
        {
            return View();
        }

    }
}
