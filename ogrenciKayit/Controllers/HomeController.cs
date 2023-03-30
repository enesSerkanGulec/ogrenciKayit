using Microsoft.AspNetCore.Mvc;

namespace ogrenciKayit.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
