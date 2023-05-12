using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TravelTripProje.Models.Siniflar
{
    public class BlogYorum
    {
        public IEnumerable<Blog> Deger1 { get; set; } //bir view içerisine birden fazla tablodan veri çekebilmek için "IEnumerable" yapısını kullandık.
        public IEnumerable<Yorumlar> Deger2 { get; set; }
        public IEnumerable<Blog> Deger3 { get; set; } //son bloglar kısmında son blogları listelemek için deger3 adında bir property oluşturduk.
        public IEnumerable <Yorumlar> Deger4 { get; set; }//son yorumlar kısmında son blogları listelemek için deger3 adında bir property oluşturduk.
    }
}