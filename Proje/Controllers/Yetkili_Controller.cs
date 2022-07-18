using proje.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Proje.Controllers
{
    public class Yetkili_Controller : Controller
    {
        // GET: Yetkili_
        public ActionResult tumYetkilileriDondur()
        {
            YetkiliCTX yetkili = new YetkiliCTX();
            var a = yetkili.tumYetkilileriDondur();
            return View();
        }
        public ActionResult tekYetkiliDondur()
        {
            YetkiliCTX yetkili = new YetkiliCTX();
            var a = yetkili.tekYetkiliDondur();
            return View();
        }
        public ActionResult YetkiliEkle()
        {
            YetkiliCTX yetkili = new YetkiliCTX();
            var a = yetkili.YetkiliEkle();
            return View();
        }
        public ActionResult YetkiliDuzenle()
        {
            YetkiliCTX yetkili = new YetkiliCTX();
            var a = yetkili.YetkiliDuzenle();
            return View();
        }
        public ActionResult YetkiliSil()
        {
            YetkiliCTX yetkili = new YetkiliCTX();
            var a = yetkili.YetkiliSil();
            return View();
        }





    }
}