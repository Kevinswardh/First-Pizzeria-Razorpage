using Microsoft.AspNetCore.Mvc;

namespace WebApplication5
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult order()
        {
            return View();
        }
    }
}
