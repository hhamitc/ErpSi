using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErpSinav.Entity
{
    public class Context : DbContext
    {
        public Context() : base("connection") { }
        public DbSet<Kategori> kategoris { get; set; }
        public DbSet<Urun> uruns{ get; set; }
        public DbSet<Satis> Satis { get; set; }
       
    }
}
