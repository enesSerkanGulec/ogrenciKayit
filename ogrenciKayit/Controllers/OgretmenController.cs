using Microsoft.AspNetCore.Mvc;

namespace ogrenciKayit.Controllers
{
    public class OgretmenController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ekle()
        {

            ViewBag.mesaj = "Hoşgeldin ya şehr-i Ramazan";

            return View();
        }
    }
}
