using HH.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

namespace HH.Controllers
{
    public class HomeController : Controller
    {
        HealthDBContext dc = new HealthDBContext();
        public ActionResult Index()
        {
            return View(dc.ExerciseList);
            
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
    }
}