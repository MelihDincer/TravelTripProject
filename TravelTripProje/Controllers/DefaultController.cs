using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProje.Models.Siniflar;

namespace TravelTripProje.Controllers
{
    public class DefaultController : Controller
    {
        Context c = new Context();
        public ActionResult Index()
        {
            var degerler = c.Blogs.Take(4).ToList();
            return View(degerler);
        }
        public ActionResult About()
        {
            return View();
        }
        //Partial1 de öne çıkan bloglar olarak son iki blog gösterildi.
        public PartialViewResult Partial1()
        {
            var degerler = c.Blogs.OrderByDescending(x => x.ID).Take(2).ToList(); //orderbydescending metodu Z'den A'ya sıralama için kullanılır.Burada z'den a'ya sıralayıp ID'ye göre son 2 veriyi listelemesini istedik.
            return PartialView(degerler);
        }
        //Partial2 yi Partial1 içerisinde kullandık. Partial2 de son iki blogun yanına id=5 olan blog konuldu. O satırda toplamda 3 blog oldu.
        public PartialViewResult Partial2()
        {
            var deger = c.Blogs.Where(x => x.ID == 5).ToList();
            return PartialView(deger);
        }
        //En Popüler 10 Blog Partial3 te getirildi.
        public PartialViewResult Partial3()
        {
            var deger = c.Blogs.Take(10).ToList();
            return PartialView(deger);
        }
        //En Beğendiğim Yerler Partial4 te getirildi.
        public PartialViewResult Partial4()
        {
            var deger = c.Blogs.Take(3).ToList();
            return PartialView(deger);
        }
        //Partial5 i Partial4 içerisinde kullandık.
        public PartialViewResult Partial5()
        {
            var deger = c.Blogs.Take(3).OrderByDescending(x => x.ID).ToList(); //orderbydescending metodu Z'den A'ya sıralama için kullanılır.Burada z'den a'ya sıralayıp ID'ye göre son 3 veriyi listelemesini istedik.
            return PartialView(deger);
        }
    }
}