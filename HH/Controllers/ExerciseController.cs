using HH.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using System.IO;

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
            return View(dc.ExerciseList.Find(id));
        }
        #endregion

        #region Add New Excercise
        public ActionResult Create()
        {
            return View();
        }

        // POST: Exercise/Create
        [HttpPost]
        public ActionResult Create(Exercise exercise, HttpPostedFileBase selectedFile)
        {
            try
            {
                if (selectedFile != null)
                {
                    //Checking whether the folder "Uploads" is exists or not and creating it if not exists
                    string PhysicalPath = Server.MapPath("~/Uploads/");
                    if (!Directory.Exists(PhysicalPath))
                    {
                        Directory.CreateDirectory(PhysicalPath);
                    }
                    selectedFile.SaveAs(PhysicalPath + selectedFile.FileName);
                    exercise.Images = selectedFile.FileName;
                }

                dc.ExerciseList.Add(exercise);
                dc.SaveChanges();

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
