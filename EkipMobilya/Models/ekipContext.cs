using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EkipMobilya.Models
{
    public class ekipContext : DbContext
    {
        static ekipContext()
        {
            Database.SetInitializer<ekipContext>(null);
        }
        public ekipContext():base("dataConnection")
        {
        }
        public DbSet <AnaKategoriler> anakategoriler { get; set; }
        public DbSet<Banner> banner { get; set; }
        public DbSet<Blog> blog { get; set; }
        public DbSet<DetayFoto> detayfoto { get; set; }
        public DbSet<DetayIcerik> detayicerik { get; set; }
        public DbSet<Footer> footer { get; set; }
        public DbSet<Galeri> galeri { get; set; }
        public DbSet<Hakkimizda> hakkimizda { get; set; }
        public DbSet<Kart> kart { get; set; }
        public DbSet<Koleksiyon> koleksiyon { get; set; }
        public DbSet<KoleksiyonBaslik> koleksiyonbaslik { get; set; }
        public DbSet<Renkler> renkler { get; set; }
        public DbSet<Slaytlar> slaytlar { get; set; }

    }
}