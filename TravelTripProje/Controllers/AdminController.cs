using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProje.Models.Siniflar;

namespace TravelTripProje.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin

        Context c = new Context();
        public ActionResult Index()
        {
            var degerler = c.Blogs.ToList();
            return View(degerler);
        }

        [HttpGet] //sayfa yüklendiğinde
        public ActionResult YeniBlog()
        {
            return View(); //sayfanın boş halini döndür.
        }

        [HttpPost] //sayfada işlem yapıldığında
        public ActionResult YeniBlog(Blog p)
        {
            c.Blogs.Add(p); //contextten ürettiğim c nesnesine bağlı olarak parametreden gelen değerleri(Textboxforlardan gelen)bloglar içerisine ekle.
            c.SaveChanges();
            return RedirectToAction("Index"); //Index aksiyonuna yönlendir.
        }

        public ActionResult BlogSil(int id)
        {
            var b = c.Blogs.Find(id); //b değerinde değişken tanımla, bu da c'nin içindeki bloglarda id yi bulsun.
            c.Blogs.Remove(b); // c'nin içindeki bloglar için tanımladığımız b değeri silinsin.
            c.SaveChanges(); // kaydet
            return RedirectToAction("Index"); //index 'e yönlendir
        }



        //GÜNCELLEME İÇİN KODLAR
        public ActionResult BlogGetir(int id)
        {
            var bl = c.Blogs.Find(id);
            return View("BlogGetir", bl); // blog getir sayfasını döndür ve bl'den gelen değerleri de getir.
        }

        public ActionResult BlogGuncelle(Blog b)
        {
            var blg = c.Blogs.Find(b.ID);
            blg.Aciklama = b.Aciklama;
            blg.Baslik = b.Baslik;
            blg.BlogImage = b.BlogImage;
            blg.Tarih = b.Tarih;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
    }

}