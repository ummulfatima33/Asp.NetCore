using Microsoft.AspNetCore.Mvc;

namespace introApp
{
    public class AdminController : Controller
    {
      public  IActionResult index()
        {
            return View();
        }
    }
}
