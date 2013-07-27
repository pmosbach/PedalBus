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
    public class GroupController : Controller
    {
        private PedalBusDb db = new PedalBusDb();

        //
        // GET: /Group/
        public ActionResult Index()
        {
            return View(db.Groups.ToList());
        }

        //
        // GET: /Group/Details/5
        public ActionResult Details(Int32 id)
        {
            Group group = db.Groups.Find(id);
            if (group == null)
            {
                return HttpNotFound();
            }
            return View(group);
        }

        //
        // GET: /Group/Create
        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Group/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Group group)
        {
            if (ModelState.IsValid)
            {
                db.Groups.Add(group);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(group);
        }

        //
        // GET: /Group/Edit/5
        public ActionResult Edit(Int32 id)
        {
            Group group = db.Groups.Find(id);
            if (group == null)
            {
                return HttpNotFound();
            }
            return View(group);
        }

        //
        // POST: /Group/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Group group)
        {
            if (ModelState.IsValid)
            {
                db.Entry(group).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(group);
        }

        //
        // GET: /Group/Delete/5
        public ActionResult Delete(Int32 id)
        {
            Group group = db.Groups.Find(id);
            if (group == null)
            {
                return HttpNotFound();
            }
            return View(group);
        }

        //
        // POST: /Group/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(Int32 id)
        {
            Group group = db.Groups.Find(id);
            db.Groups.Remove(group);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        // Experimental Helper Method
        [ChildActionOnly]
        public ActionResult GetGroupName(Int32 id)
        {
            var query = db.Groups.Where(r => r.Id == id).First();
            return Content(query.LongName);
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}
