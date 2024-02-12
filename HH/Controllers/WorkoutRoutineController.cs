using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HH.Controllers
{
    public class WorkoutRoutineController : Controller
    {
        // GET: WorkoutRoutine
        public ActionResult Index()
        {
            return View();
        }

        
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: WorkoutRoutine/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: WorkoutRoutine/Create
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

        // GET: WorkoutRoutine/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: WorkoutRoutine/Edit/5
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

        // GET: WorkoutRoutine/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: WorkoutRoutine/Delete/5
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
    }
}
