using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ApplyLoanApplication.Models;

namespace ApplyLoanApplication.Controllers
{
    public class DocumentsController : Controller
    {
        private LoanApplicationEntities2 db = new LoanApplicationEntities2();

        // GET: Documents
        public ActionResult Index()
        {
            return View(db.loanDocuments.ToList());
        }

        // GET: Documents/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            loanDocument loanDocument = db.loanDocuments.Find(id);
            if (loanDocument == null)
            {
                return HttpNotFound();
            }
            return View(loanDocument);
        }

        // GET: Documents/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Documents/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "DocumentCode,DocumentDescription")] loanDocument loanDocument)
        {
            if (ModelState.IsValid)
            {
                db.loanDocuments.Add(loanDocument);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(loanDocument);
        }

        // GET: Documents/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            loanDocument loanDocument = db.loanDocuments.Find(id);
            if (loanDocument == null)
            {
                return HttpNotFound();
            }
            return View(loanDocument);
        }

        // POST: Documents/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "DocumentCode,DocumentDescription")] loanDocument loanDocument)
        {
            if (ModelState.IsValid)
            {
                db.Entry(loanDocument).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(loanDocument);
        }

        // GET: Documents/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            loanDocument loanDocument = db.loanDocuments.Find(id);
            if (loanDocument == null)
            {
                return HttpNotFound();
            }
            return View(loanDocument);
        }

        // POST: Documents/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            loanDocument loanDocument = db.loanDocuments.Find(id);
            db.loanDocuments.Remove(loanDocument);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
