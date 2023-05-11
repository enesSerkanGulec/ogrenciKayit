using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.FlowAnalysis.DataFlow;
using ogrenciKayit.Models;

namespace ogrenciKayit.Controllers
{
    public class OgrenciController : Controller
    {
        Context Db = new();


        List<string> siniflar = new List<string>() { "9A", "10A", "11A","12A" };
        List<string> bolumler = new List<string>() { "Bilişim", "Elektrik-Elektronik", "Makina" };

        public IActionResult Index()
        {
            var ogrenciListesi= Db.Ogrenci.ToList();
            return View(ogrenciListesi);
        }

        public IActionResult ekle()
        {
            ViewBag.siniflar = siniflar;
            ViewBag.bolumler = bolumler;
            return View();
        }

        [HttpPost]
        public IActionResult ekle(Ogrenci x)
        {
            Db.Ogrenci.Add(x);
            Db.SaveChanges();
            TempData["mesaj"] = x.Ad + " " + x.Soyad;
            return RedirectToAction("index");
        }

        public IActionResult sil(int id)
        {
            var silinecek = Db.Ogrenci.Where(x => x.Id == id).FirstOrDefault();
            if (silinecek!=null)
            {
                Db.Ogrenci.Remove(silinecek);
                Db.SaveChanges();
                TempData["silinen"] = silinecek.Ad + " " + silinecek.Soyad;
            }
            return RedirectToAction("index");
        }
    }
}
