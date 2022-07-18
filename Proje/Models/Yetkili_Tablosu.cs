using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proje.Models
{
    public class Yetkili_Tablosu
    {
        public int KayitYapanID { get; set; }
        public string TC { get; set; }
        public int Aktif { get; set; }
        public DateTime Tarih { get; set; }
    }
}