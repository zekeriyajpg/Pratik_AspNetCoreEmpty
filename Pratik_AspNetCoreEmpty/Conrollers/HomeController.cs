using Microsoft.AspNetCore.Mvc;

namespace Pratik_AspNetCoreEmpty.Conrollers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
