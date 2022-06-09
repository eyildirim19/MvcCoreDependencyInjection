using Microsoft.AspNetCore.Mvc;

namespace MvcCoreDependencyInjection.Controllers
{
    using Models;
    public class HomeController : Controller
    {
        MYCLASS my;
        public HomeController(MYCLASS _my)
        {
            my = _my;
        }

        public IActionResult Index()
        {
            return View(my.Topla(2, 2));
        }
    }
}