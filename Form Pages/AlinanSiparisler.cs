using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KafeOtomasyonu.Entity;

namespace KafeOtomasyonu
{
    class AlinanSiparisler
    {
        Context c = new Context();

        public void SiparisAl(int masa,string siparis, int ucret)
        {
            SiparislerDB sDB = new SiparislerDB();
            sDB.MasaNo=masa;
            sDB.Siparis = siparis;
            sDB.Fiyat = ucret;
            c.SiparislerDBs.Add(sDB);
            c.SaveChanges();
        }

        
    }
}
