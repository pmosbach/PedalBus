using PedalBus.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PedalBus.Controllers
{
    public class ApplicationController : Controller
    {
        private PedalBusDb db = new PedalBusDb();

        // TODO: Explore ChildActionOnly annotation

        //
        // GET: /Application/
        public ActionResult Index()
        {
            return View(db.Applications.ToList());
        }

        //
        // GET: /Application/Details/5
        public ActionResult Details(Int32 id)
        {
            Application application = db.Applications.Find(id);
            if (application == null)
            {
                return HttpNotFound();
            }
            return View(application);
        }

        //
        // GET: /Application/Create
        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Application/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Application application)
        {
            if (ModelState.IsValid)
            {
                application.LastAction = "Application Created";
                application.LastRemoteUser = User.Identity.Name;
                application.LastRemoteAddr = Request.UserHostAddress;
                application.LastModified = DateTime.Now;
                application.Groups = new List<Group>
                { 
                    new Group
                    {
                        ShortName = "Regular Users",
                        LongName = "Regular Users",
                        Advertise = true,
                        Privileged = false,
                        Pseudo = true,
                        Sensitivity = InformationSensitivity.Unknown,
                        LastAction = "Group Created",
                        LastRemoteUser = User.Identity.Name,
                        LastRemoteAddr = Request.UserHostAddress,
                        LastModified = DateTime.Now
                    }
                };
                db.Applications.Add(application);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(application);
        }

        //
        // GET: /Application/Edit/5
        public ActionResult Edit(Int32 id)
        {
            Application application = db.Applications.Find(id);
            if (application == null)
            {
                return HttpNotFound();
            }
            return View(application);
        }

        //
        // POST: /Application/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        // TODO: Add Mass Assignment prevention to all Post actions that take user input through either Binding with a whitelist or a ViewModel for user input.
        public ActionResult Edit(Application application)
        {
            if (ModelState.IsValid)
            {
                application.LastAction = "Application Modified";
                application.LastRemoteUser = User.Identity.Name;
                application.LastRemoteAddr = Request.UserHostAddress;
                application.LastModified = DateTime.Now;
                db.Entry(application).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(application);
        }

        //
        // GET: /Application/Delete/5
        public ActionResult Delete(Int32 id)
        {
            Application application = db.Applications.Find(id);
            if (application == null)
            {
                return HttpNotFound();
            }
            return View(application);
        }

        //
        // POST: /Application/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(Int32 id)
        {
            Application application = db.Applications.Find(id);
            db.Applications.Remove(application);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        // Experimental Helper Method
        [ChildActionOnly]
        public ActionResult GetApplicationName(Int32 id)
        {
            var query = db.Applications.Where(r => r.Id == id).First();
            return Content(query.LongName);
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}
