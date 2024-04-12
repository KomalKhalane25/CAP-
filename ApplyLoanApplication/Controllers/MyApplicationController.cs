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
    public class MyApplicationController : Controller
    {
        private LoanApplicationEntities2 db = new LoanApplicationEntities2();

        // GET: MyApplication
        public ActionResult Index()
        {
            return View();//(db.LoanApplications.ToList());
        }
    

//        // GET: MyApplication/Details/5
//        public ActionResult Details(int? id)
//        {
//            if (id == null)
//            {
//                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
//            }
//            LoanApplication loanApplication = db.LoanApplications.Find(id);
//            if (loanApplication == null)
//            {
//                return HttpNotFound();
//            }
//            return View(loanApplication);
//        }

//        // GET: MyApplication/Create
//        public ActionResult Create()
//        {
//            return View();
//        }

//        // POST: MyApplication/Create
//        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
//        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public ActionResult Create([Bind(Include = "ApplicationNumber,ApplicationDate,CustomerName,Gender,BirthDate,Age,MobileNo,EmailId,SelectedLoanType,RequiredLoanAmount,RateOfInterest,LoanTenure,LoanEMI,SanctionedAmount,SanctionedTenure,SanctionedInterestRate,SanctionedEMI,LoanStatus,RejectionRemark")] LoanApplication loanApplication)
//        {
//            if (ModelState.IsValid)
//            {
//                db.LoanApplications.Add(loanApplication);
//                db.SaveChanges();
//                return RedirectToAction("Index");
//            }

//            return View(loanApplication);
//        }

//        // GET: MyApplication/Edit/5
//        public ActionResult Edit(int? id)
//        {
//            if (id == null)
//            {
//                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
//            }
//            LoanApplication loanApplication = db.LoanApplications.Find(id);
//            if (loanApplication == null)
//            {
//                return HttpNotFound();
//            }
//            return View(loanApplication);
//        }

//        // POST: MyApplication/Edit/5
//        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
//        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public ActionResult Edit([Bind(Include = "ApplicationNumber,ApplicationDate,CustomerName,Gender,BirthDate,Age,MobileNo,EmailId,SelectedLoanType,RequiredLoanAmount,RateOfInterest,LoanTenure,LoanEMI,SanctionedAmount,SanctionedTenure,SanctionedInterestRate,SanctionedEMI,LoanStatus,RejectionRemark")] LoanApplication loanApplication)
//        {
//            if (ModelState.IsValid)
//            {
//                db.Entry(loanApplication).State = EntityState.Modified;
//                db.SaveChanges();
//                return RedirectToAction("Index");
//            }
//            return View(loanApplication);
//        }

//        // GET: MyApplication/Delete/5
//        public ActionResult Delete(int? id)
//        {
//            if (id == null)
//            {
//                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
//            }
//            LoanApplication loanApplication = db.LoanApplications.Find(id);
//            if (loanApplication == null)
//            {
//                return HttpNotFound();
//            }
//            return View(loanApplication);
//        }

//        // POST: MyApplication/Delete/5
//        [HttpPost, ActionName("Delete")]
//        [ValidateAntiForgeryToken]
//        public ActionResult DeleteConfirmed(int id)
//        {
//            LoanApplication loanApplication = db.LoanApplications.Find(id);
//            db.LoanApplications.Remove(loanApplication);
//            db.SaveChanges();
//            return RedirectToAction("Index");
//        }

//        protected override void Dispose(bool disposing)
//        {
//            if (disposing)
//            {
//                db.Dispose();
//            }
//            base.Dispose(disposing);
//        }
   }
}
