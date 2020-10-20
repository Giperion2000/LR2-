using LR2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LR2.Controllers
{
    public class HomeController : Controller
    {
        ApplicationDbContext context = new ApplicationDbContext();
        public ActionResult Index()
        {
            IEnumerable<Strahov> strahovs = context.Strahovs;

            ViewBag.Strahovs = strahovs;
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        [HttpGet]
        public ActionResult More(int id)
        {
            ViewBag.StrahovId = id;

            Strahov strahov = context.Strahovs.Find(id);
            if (strahov != null)
            {
                return View(strahov);
            }
            return View("More");
        }
    }
}