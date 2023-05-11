using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using TravelTripProje.Models.Siniflar;

namespace TravelTripProje.Controllers
{
    public class GirisYapController : Controller
    {
        Context c = new Context();
        public ActionResult Login()
        {
            return View();
        }
        //Giriş İşlemi
        [HttpPost]
        public ActionResult Login(Admin ad)
        {
            var bilgiler = c.Admins.FirstOrDefault(x => x.Kullanici == ad.Kullanici && x.Sifre == ad.Sifre);
            if (bilgiler != null)
            {
                FormsAuthentication.SetAuthCookie(bilgiler.Kullanici, false); //Cookileri set
                Session["Kullanici"]= bilgiler.Kullanici.ToString();
                return RedirectToAction("Index","Admin");
            }
            else 
            { 
                return View(); 
            }
        }
        //Çıkış İşlemi
        public ActionResult Logout() 
        {
            FormsAuthentication.SignOut();//Bu şekilde bir çıkış işlemi yapıldığında, tarayıcıda direkt olarak /Admin/Index sayfasına erişimi engellenmiş halde giriş sayfasına yönlendirmekteyiz.
            return RedirectToAction("Login");
        }
    }
}