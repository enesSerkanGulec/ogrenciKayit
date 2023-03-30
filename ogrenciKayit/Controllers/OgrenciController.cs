using Microsoft.AspNetCore.Mvc;
using ogrenciKayit.Models;

namespace ogrenciKayit.Controllers
{
    public class OgrenciController : Controller
    {

        static List<DB_ogrenci> ogrenciListesi = new List<DB_ogrenci>();

        public IActionResult Index()
        {
            ViewBag.ogrenciListesi= ogrenciListesi;
            return View();
        }

        public IActionResult ekle()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ekle(string ad,string soyad,int numara,string sinif)
        {
            ogrenciListesi.Add(new DB_ogrenci() { Ad=ad,Soyad=soyad,Numara=numara,Sinif=sinif});


            return RedirectToAction("index");
        }
    }
}
