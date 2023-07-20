using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KafeOtomasyonu.Entity
{
    public class AdminDB
    {
        [Key]
        public int ID { get; set; }
        public string KullaniciAdi { get; set; }
        public string Sifre { get; set; }
    }
}
