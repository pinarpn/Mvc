using proje.Repos;
using Proje.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Dapper;
using GetConnection;
using System.Collections;

namespace Proje.Controllers
{
    public class Etkinlik_Controller : Controller
    {
        // GET: Etkinlik_Tablosu
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult tumEtkinlikleriDondur()
        {
            Etkinlik_TablosuCTX etkinlik = new Etkinlik_TablosuCTX();
            var a = etkinlik.tumEtkinlikleriDondur();
            return View(a);
        }
        public ActionResult tekEtkinlikDondur()
        {
            Etkinlik_TablosuCTX salon = new Etkinlik_TablosuCTX();
            var a = salon.tekEtkinlikDondur();
            return View();
        }
        public List<salon> salonKategori()
        {
            SalonCTX egpct = new SalonCTX();
            List<salon> salonListesi = new List<salon>();
            foreach (var x in egpct.tumSalonlariDondur())
            {
                salon bl = new salon();
                bl.id = x.SalonID;
                bl.salonAdi = x.SalonAdi;
                salonListesi.Add(bl);
            }
            return salonListesi;
        }
        public class salon
        {
            public int id { set; get; }
            public string salonAdi { set; get; }
        }
        public List<kategori> kategoriler()
        {
            Etkinlik_KategorileriCTX egpct = new Etkinlik_KategorileriCTX();
            List<kategori> kategoriListesi = new List<kategori>();
            foreach (var x in egpct.tumKategorileriDondur())
            {
                kategori bl = new kategori();
                bl.id = x.KategoriID;
                bl.kategoriAdi = x.KategoriAdi;
                kategoriListesi.Add(bl);
            }
            return kategoriListesi;
        }

        public class kategori
        {
            public int id { set; get; }
            public string kategoriAdi { set; get; }
        }
        public ActionResult EtkinlikEkle()
        {
            Etkinlik_TablosuCTX sct = new Etkinlik_TablosuCTX();
            //sct.EtkinlikEkle(KDKD);
            ViewBag.salon = new SelectList(salonKategori(), "id", "salonAdi");
            ViewBag.kategori = new SelectList(kategoriler(), "id", "kategoriAdi");
            //return RedirectToAction("tumEtkinlikleriDondur");
            return View();
        }
        [HttpPost]
        public ActionResult EtkinlikEkle(Etkinlik etkn)
        {
            Etkinlik_TablosuCTX asd = new Etkinlik_TablosuCTX();
            asd.EtkinlikEkle(etkn);
            return RedirectToAction("tumEtkinlikleriDondur");

        }

    }
}