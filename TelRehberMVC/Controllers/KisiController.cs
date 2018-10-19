using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TelRehberMVC.Models;
using TelRehberMVC.Models.Managers;

namespace TelRehberMVC.Controllers
{
    public class KisiController : Controller
    {
        // GET: Kisi
        public ActionResult Yeni()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Yeni(Kisiler kisi)
        {
            DatabaseContext db = new DatabaseContext();
            db.Kisiler.Add(kisi);

            int sonuc = db.SaveChanges();
            if(sonuc > 0)
            {
                ViewBag.Result = "Kişi Kaydedilmiştir.";
                ViewBag.Status = "success";
            }
            else
            {
                ViewBag.Result = "Kişi Kaydedilememiştir.";
                ViewBag.Status = "denger";
            }

            
            return View();
        }
    }
}