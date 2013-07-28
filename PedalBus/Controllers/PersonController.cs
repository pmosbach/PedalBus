using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PedalBus.Models;

namespace PedalBus.Controllers
{
    public class PersonController : Controller
    {
        private PedalBusDb db = new PedalBusDb();

        //
        // GET: /Person/
        public ActionResult Index()
        {
            return View(db.People.ToList());
        }

        //
        // GET: /Person/Details/5
        public ActionResult Details(Int32 id)
        {
            Person person = db.People.Find(id);
            if (person == null)
            {
                return HttpNotFound();
            }
            return View(person);
        }

        //
        // GET: /Person/Create
        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Person/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Person person)
        {
            if (ModelState.IsValid)
            {
                db.People.Add(person);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(person);
        }

        //
        // GET: /Person/Edit/5
        public ActionResult Edit(Int32 id)
        {
            Person person = db.People.Find(id);
            if (person == null)
            {
                return HttpNotFound();
            }
            return View(person);
        }

        //
        // POST: /Person/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Person person)
        {
            if (ModelState.IsValid)
            {
                db.Entry(person).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(person);
        }

        //
        // GET: /Person/EditContactInformation
        public ActionResult EditContactInformation()
        {
            Person person = db.People.Where(a => a.DomainID == User.Identity.Name).SingleOrDefault();
            if (person == null)
            {
                return HttpNotFound();
            }
            return View(person);
        }

        //
        // TODO: Experiment with pjax.submit
        // POST: /Person/EditContactInformation
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditContactInformation(Person person)
        {
            if (ModelState.IsValid)
            {
                db.Entry(person).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(person);
        }

        //
        // GET: /Person/EditBackgroundSurvey
        public ActionResult EditBackgroundSurvey()
        {
            Person person = db.People.Where(a => a.DomainID == User.Identity.Name).SingleOrDefault();
            if (person == null)
            {
                return HttpNotFound();
            }
            return View(person);
        }

        //
        // POST: /Person/EditBackgroundSurvey
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditBackgroundSurvey(Person person)
        {
            if (ModelState.IsValid)
            {
                db.Entry(person).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(person);
        }

        //
        // GET: /Person/EditManager
        public ActionResult EditManager()
        {
            Person person = db.People.Where(a => a.DomainID == User.Identity.Name).SingleOrDefault();
            if (person == null)
            {
                return HttpNotFound();
            }
            return View(person);
        }

        //
        // POST: /Person/EditManager
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditManager(Person person)
        {
            if (ModelState.IsValid)
            {
                db.Entry(person).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(person);
        }

        //
        // GET: /Person/Delete/5
        public ActionResult Delete(Int32 id)
        {
            Person person = db.People.Find(id);
            if (person == null)
            {
                return HttpNotFound();
            }
            return View(person);
        }

        //
        // POST: /Person/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(Int32 id)
        {
            Person person = db.People.Find(id);
            db.People.Remove(person);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}
