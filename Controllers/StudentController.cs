using PUAP20222_vjezba.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PUAP20222_vjezba.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            ViewBag.Title = "Pocetna o studentima";
            ViewBag.Fakultet = "Medimursko veleuciliste";
            return View();
        }

        public ActionResult Popis()
        {
            StudentDBcs studentDBcs = new StudentDBcs();
            return View(studentDBcs);
        }


        public ActionResult Detalji(int? id)
        {
            if (!id.HasValue)
                RedirectToAction("Popis");
            StudentDBcs studentDBcs = new StudentDBcs();
            Student student = studentDBcs.VratiListu().FirstOrDefault(x => x.Id == id);
            if (student == null)
            {
                RedirectToAction("Popis");
            }
            return View(student);
        }




    }
}