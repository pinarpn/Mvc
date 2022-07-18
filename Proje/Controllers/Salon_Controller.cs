using proje.Repos;
using Proje.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Proje.Controllers
{
    public class Salon_Controller : Controller
    {
        // GET: Salon_
        public ActionResult tumSalonlariDondur()
        {
            SalonCTX salon = new SalonCTX();
            var a = salon.tumSalonlariDondur();
            return View(a);
        }
        public ActionResult tekSalonDondur()
        {
            SalonCTX salon = new SalonCTX();
            var a = salon.tekSalonDondur();
            return View();
        }

        public ActionResult salonEkle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult salonEkle(Salon_Tablosu sln)
        {
            SalonCTX sct = new SalonCTX();
            sct.salonEkle(sln);
            return RedirectToAction("tumSalonlariDondur");
        }
        public ActionResult salonDuzenle(int SalonID)
        {
            SalonCTX salon = new SalonCTX();
            var c = salon.tekSalonDondur(SalonID);
            return View(c);
        }
        [HttpPost]
        public ActionResult salonDuzenle(Salon_Tablosu salon)
        {
            SalonCTX sctx = new SalonCTX();
            var c = sctx.salonDuzenle(salon);
            return RedirectToAction("tumSalonlariDondur");
        }

     public ActionResult salonSil(int SalonID)
        {
            SalonCTX salon = new SalonCTX();
            salon.salonSil(SalonID);
            return RedirectToAction("tumSalonlariDondur");
        }

       

    }
}