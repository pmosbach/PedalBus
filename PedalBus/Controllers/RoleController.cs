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
    public class RoleController : Controller
    {
        private PedalBusDb db = new PedalBusDb();

        //
        // GET: /Role/
        public ActionResult Index()
        {
            return View(db.Roles.ToList());
        }

        //
        // GET: /Role/Details/5
        public ActionResult Details(Int32 id)
        {
            Role role = db.Roles.Find(id);
            if (role == null)
            {
                return HttpNotFound();
            }
            return View(role);
        }

        //
        // GET: /Role/Create
        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Role/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Role role)
        {
            if (ModelState.IsValid)
            {
                db.Roles.Add(role);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(role);
        }

        //
        // GET: /Role/Edit/5
        public ActionResult Edit(Int32 id)
        {
            Role role = db.Roles.Find(id);
            if (role == null)
            {
                return HttpNotFound();
            }
            return View(role);
        }

        //
        // POST: /Role/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Role role)
        {
            if (ModelState.IsValid)
            {
                db.Entry(role).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(role);
        }

        //
        // GET: /Role/Delete/5
        public ActionResult Delete(Int32 id)
        {
            Role role = db.Roles.Find(id);
            if (role == null)
            {
                return HttpNotFound();
            }
            return View(role);
        }

        //
        // POST: /Role/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(Int32 id)
        {
            Role role = db.Roles.Find(id);
            db.Roles.Remove(role);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        // Experimental Helper Method
        [ChildActionOnly]
        public ActionResult GetNameOfPrime(Int32 id)
        {
            var rolequery = db.PeopleRoles.Where(r => r.RoleId == id && r.Prime == true).First();
            var query = db.People.Where(r => r.Id == rolequery.PersonId).First();
            return Content(query.DisplayName);
        }

        // Experimental Helper Method
        [ChildActionOnly]
        public ActionResult GetRoleName(Int32 id)
        {
            var query = db.Roles.Where(r => r.Id == id).First();
            return Content(query.Name);
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}
