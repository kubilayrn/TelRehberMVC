using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TelRehberMVC.Models;
using TelRehberMVC.Models.Managers;
using TelRehberMVC.ViewModels.Home;

namespace TelRehberMVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult homepage()
        {
            DatabaseContext db = new DatabaseContext();
            //List<Kisiler> kisiler = db.Kisiler.ToList();
            HomePageViewModel model = new HomePageViewModel();
            model.Kisiler = db.Kisiler.ToList();
            return View(model);
        }
    }
}