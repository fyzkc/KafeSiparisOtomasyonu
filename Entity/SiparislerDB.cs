using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KafeOtomasyonu.Entity
{
    public class SiparislerDB
    {
        [Key]
        public int ID { get; set; }
        public int MasaNo { get; set; }
        public string Siparis { get; set; }
        public int Fiyat { get; set; }


    }
}
