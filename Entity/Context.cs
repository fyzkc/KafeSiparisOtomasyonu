using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace KafeOtomasyonu.Entity
{
    class Context : DbContext
    {
        
        public DbSet<AdminDB> AdminDBs { get; set; }
        public DbSet<SiparislerDB> SiparislerDBs { get; set; }
    }
}
