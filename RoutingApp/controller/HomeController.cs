using Microsoft.AspNetCore.Mvc;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace RoutingApp.controller
{
    public class HomeController : Controller
    {
        [Route("Home/Index")]   // This is Attribute
        [Route("~/")]
        public string Index()
        {
            return "index page";
        }
         
        [Route("Home/About")]
        public string About()
        {
            return "About page";
        }

        //with Query Parameter

        [Route("Home/Details/{name}")]
        public string Details(string name)
        {
            return name;
        }
    }
}
