using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proje.Models
{
    public class Etkinlik
    {
        public int EtkinlikID { get; set; }
        public int KayitYapanID { get; set; }
        public int SalonID { get; set; }
        public int KategoriID { get; set; }
        public string EtkinlikAdi { get; set; }
        public string TalepBirim { get; set; }
        public string TalepKisiTC { get; set; }
        public DateTime BaslangicTarih { get; set; }
        public DateTime BitisTarih { get; set; }
        //sadece yardımcı bilgi olarak gerekli bu yüzden string tuttuk...databasede de güncelleyin
        public string BaslangicSaat { get; set; }
        public string BitisSaat { get; set; }
        public string Aciklama { get; set; }
        public int EvrakNo { get; set; }
        public int EtkinlikNo { get; set; }
        //bunları ilişki tutacağız
        public Yetkili_Tablosu KayitYapanid { get; set; }
        public Salon_Tablosu Salonid { get; set; }
        public Etkinlik_Kategorileri Kategoriid { get; set; }
    }
}