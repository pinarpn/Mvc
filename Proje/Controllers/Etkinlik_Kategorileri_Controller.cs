using proje.Repos;
using Proje.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Dapper;
using GetConnection;

namespace Proje.Controllers
{
    public class Etkinlik_Kategorileri_Controller : Controller
    {
        // GET: Etkinlik_Kategorileri_
        public ActionResult tumKategorileriDondur()
        {
            Etkinlik_KategorileriCTX kategori = new Etkinlik_KategorileriCTX();
            var a = kategori.tumKategorileriDondur();
            return View(a);
        }
        public ActionResult tekKategoriDondur(int KategoriID)
        {
            //Etkinlik_KategorileriCTX kategori = new Etkinlik_KategorileriCTX();
            //var a = kategori.tekKategoriDondur();
            baglanti bag = new baglanti();
            var tmp = new Etkinlik_Kategorileri();
            using (var x = bag.GetConnection())
            {
                string sorgu = "select * from Etkinlik_Kategorileri where KategoriID  = @id";
                tmp = x.Query<Etkinlik_Kategorileri>(sorgu, new { id = KategoriID }).FirstOrDefault();
            }
            return View(tmp);
        }
        public ActionResult KategoriEkle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult KategoriEkle(Etkinlik_Kategorileri ktgr)
        {
            Etkinlik_KategorileriCTX sct = new Etkinlik_KategorileriCTX();
            sct.KategoriEkle(ktgr);
            return RedirectToAction("tumKategorileriDondur");
        }

        public ActionResult KategoriDuzenle(int KategoriID)
        {
            //Etkinlik_KategorileriCTX kategori = new Etkinlik_KategorileriCTX();
            //var a = kategori.KategoriDuzenle();
            baglanti bag = new baglanti();
            var tmp = new Etkinlik_Kategorileri();
            using (var x = bag.GetConnection())
            {
                string sorgu = "select * from Etkinlik_Kategorileri where KategoriID = @id";
                tmp = x.Query<Etkinlik_Kategorileri>(sorgu, new { id = KategoriID }).FirstOrDefault();
            }
            return View();
        }

        [HttpPost]
        public ActionResult KategoriDuzenle(Etkinlik_Kategorileri dzn)
        {
            Etkinlik_KategorileriCTX dzen = new Etkinlik_KategorileriCTX();
            var c = dzen.KategoriDuzenle(dzn);
            return RedirectToAction("tumKategorileriDondur");
        }
        public ActionResult KategoriSil(int KategoriID)
        {
            Etkinlik_KategorileriCTX kategori = new Etkinlik_KategorileriCTX();
            kategori.KategoriSil(KategoriID);
            return RedirectToAction("tumKategorileriDondur");
        }


    }
}