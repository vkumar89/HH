using HH.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

namespace HH.Controllers
{
    public class ExerciseController : Controller
    {
        #region Connection Class Instance
        HealthDBContext dc =new HealthDBContext();
        #endregion

        #region Display all Exercise
        public ActionResult Index()
        {
            return View(dc.ExerciseList);
        }

        #endregion


        #region Display Perticular Exercise
        // GET: Exercise/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }
        #endregion

        #region Add New Excercise
        public ActionResult Create()
        {
            return View();
        }

        // POST: Exercise/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        #endregion


        #region Edit Exercise
        
        public ActionResult Edit(int id)
        {
            return View();
        }


        
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        #endregion

        // GET: Exercise/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        #region delete Excercise

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        #endregion
    }
}
