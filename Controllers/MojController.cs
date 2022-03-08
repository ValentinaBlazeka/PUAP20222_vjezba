using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PUAP20222_vjezba.Controllers
{
    public class MojController : Controller
    {
        // GET: Moj
        public ActionResult Index()
        {
            ViewBag.Lokacija = "Međimursko veleučiliste u Čakovcu";
            return View();

        }
        public ActionResult Druga()
        {
            ViewBag.Ustanova = "Medimursko veleuciliste.";
            ViewData["Lokacija"] = "Čakovec";
            return View();
        }

        public ActionResult Treca(string poruka, int broj=1)
        {
            ViewBag.Poruka = poruka;
            ViewBag.Broj = broj;
            return View();
        }
        public ActionResult student()
        {
            ViewBag.Ime = "Ana";
            ViewBag.Prezime = "Anic";
            ViewBag.GodinaRodenja = 1998;
            return View();
        }

    }
}