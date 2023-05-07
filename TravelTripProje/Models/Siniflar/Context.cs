using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace TravelTripProje.Models.Siniflar
{
    public class Context: DbContext  //dbcontext'ten miras almasaydık alt satırdaki kodda dbset gelmeyecekti.
    {
        public DbSet<Admin> Admins { get; set; }
        public DbSet<AdresBlog>AdresBlogs { get; set; }
        public DbSet<Blog>Blogs { get; set; }
        public DbSet<Hakkimizda>Hakkimizdas { get; set; }
        public DbSet<iletisim>iletisims { get; set; }
        public DbSet<Yorumlar>Yorumlars { get; set; }

    }
}