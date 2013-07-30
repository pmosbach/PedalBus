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
    public class RequestFlowController : Controller
    {
        private PedalBusDb db = new PedalBusDb();

        //
        // GET: /RequestFlow/
        public ActionResult Index()
        {
            return View(db.RequestFlows.ToList());
        }

        //
        // GET: /RequestFlow/Details/5
        public ActionResult Details(Int32 id)
        {
            RequestFlow requestflow = db.RequestFlows.Find(id);
            if (requestflow == null)
            {
                return HttpNotFound();
            }
            return View(requestflow);
        }

        //
        // GET: /RequestFlow/Create
        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /RequestFlow/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(RequestFlow requestflow)
        {
            if (ModelState.IsValid)
            {
                db.RequestFlows.Add(requestflow);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(requestflow);
        }

        //
        // GET: /RequestFlow/StartNewRequest
        public ActionResult StartNewRequest()
        {
            return View();
        }

        //
        // GET: /RequestFlow/USOR
        public ActionResult USOR()
        {
            return View();
        }

        //
        // POST: /RequestFlow/USOR
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult USOR(RequestFlow requestflow)
        {
            if (ModelState.IsValid)
            {
                requestflow.FurthestStep = "USOR";
                var id = db.People.Where(a => a.DomainID == User.Identity.Name).Single().Id;
                requestflow.RequestorId = id;
                requestflow.SubmitterId = id;
                requestflow.MatchingPersonId = id;
                requestflow.LastModified = DateTime.Now;
                db.RequestFlows.Add(requestflow);
                db.SaveChanges();
                return RedirectToAction("SpecialProcessing", new { id = requestflow.Id });
            }

            return View(requestflow);
        }


        //
        // TODO: Make sure only the requestor or submitter can access this flow directly or indirectly
        // GET: /RequestFlow/SpecialProcessing/5
        public ActionResult SpecialProcessing(Int32 id)
        {
            RequestFlow requestflow = db.RequestFlows.Find(id);
            return View(requestflow);
        }

        //
        // POST: /RequestFlow/SpecialProcessing/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SpecialProcessing(RequestFlow requestflow)
        {
            if (ModelState.IsValid)
            {
                requestflow.FurthestStep = "SpecialProcessing";
                requestflow.LastModified = DateTime.Now;
                db.Entry(requestflow).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("ProfileMatching", new { id = requestflow.Id });
            }

            return View(requestflow);
        }

        //
        // GET: /RequestFlow/ProfileMatching/5
        public ActionResult ProfileMatching(Int32 id)
        {
            RequestFlow requestflow = db.RequestFlows.Find(id);
            //if (Request.IsAjaxRequest())
            //{
            //    return PartialView();
            //}
            return View(requestflow);
        }

        //
        // POST: /RequestFlow/ProfileMatching/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ProfileMatching(RequestFlow requestflow)
        {
            if (ModelState.IsValid)
            {
                requestflow.FurthestStep = "ProfileMatching";
                requestflow.LastModified = DateTime.Now;
                db.Entry(requestflow).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("ProfileMatching", new { id = requestflow.Id });
            }

            return View(requestflow);
        }

        //
        // GET: /RequestFlow/Edit/5
        public ActionResult Edit(Int32 id)
        {
            RequestFlow requestflow = db.RequestFlows.Find(id);
            if (requestflow == null)
            {
                return HttpNotFound();
            }
            return View(requestflow);
        }

        //
        // POST: /RequestFlow/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(RequestFlow requestflow)
        {
            if (ModelState.IsValid)
            {
                db.Entry(requestflow).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(requestflow);
        }

        //
        // GET: /RequestFlow/Delete/5
        public ActionResult Delete(Int32 id)
        {
            RequestFlow requestflow = db.RequestFlows.Find(id);
            if (requestflow == null)
            {
                return HttpNotFound();
            }
            return View(requestflow);
        }

        //
        // POST: /RequestFlow/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(Int32 id)
        {
            RequestFlow requestflow = db.RequestFlows.Find(id);
            db.RequestFlows.Remove(requestflow);
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
