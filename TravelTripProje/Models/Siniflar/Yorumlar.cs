using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TravelTripProje.Models.Siniflar
{
    public class Yorumlar
    {
        public int ID { get; set; }
        public string KullaniciAdi { get; set; }
        public string Mail   { get; set; }
        public string Yorum { get; set; }
        public int Blogid { get; set; }
        public virtual Blog Blog { get; set; }  //blog tablosundan blog adında bir değer oluşturdum. property olarak dahil ettik. blog tablomdan gelecek değeri tutacak.
    }
}