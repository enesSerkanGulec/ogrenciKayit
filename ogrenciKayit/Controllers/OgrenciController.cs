using Microsoft.AspNetCore.Mvc;

namespace ogrenciKayit.Controllers
{
    public class OgrenciController : Controller
    {
        public IActionResult Index(int? id)
        {
            List<string> listAd = new List<string>() { "Atakan", "Berk", "Yusuf", "Mahmut", "İbrahim", "Sinan", "İsmail", "Buğra", "Caner" };
            List<string> listSoyad = new List<string>() { "Yumrukaya", "kutlu", "adıgüzel", "candemir", "koca", "bursalı", "Çolak", "Şeref", "Akbaş" };

            ViewBag.Adlar = listAd;
            ViewBag.Soyadlar = listSoyad;
            ViewBag.id = id;
            return View();
        }


        public IActionResult kirmizi()
        {
            return View();
        }


        public IActionResult Yesil()
        {
            return View();
        }

        public IActionResult Ekle()
        {
            //ViewBag.isim = isim;    
            return View();
        }

        [HttpPost]
        public IActionResult Ekle(string txt_ad,string txt_soyad,string txt_numara,string txt_sinif)
        {
            //ViewBag.isim = isim;    
            return View();
        }
    }
}
