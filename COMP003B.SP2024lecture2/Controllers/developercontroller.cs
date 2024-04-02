using Microsoft.AspNetCore.Mvc;

namespace COMP003B.SP2024lecture2_.Controllers
{
    public class developercontroller : Controller
    {
        // GET "Developer/Index"
        public IActionResult Index()
        {
            return View();
        }

        // GET "Developer/AboutMe"
        public IActionResult AboutMe()
        {
            return View();
        }
    }
}
