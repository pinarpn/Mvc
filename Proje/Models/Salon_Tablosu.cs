using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proje.Models
{
    public class Salon_Tablosu
    {

        public int SalonID { get; set; }
        public string SalonAdi { get; set; }
        public string SalonAciklama { get; set; }
        public int SalonKapasite { get; set; }
    }
}