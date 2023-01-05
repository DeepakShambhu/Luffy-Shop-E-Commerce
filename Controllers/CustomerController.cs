using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Project_2;

namespace Project_2.Controllers
{
    public class CustomerController : Controller
    {
        private Shapping_DBEntities db = new Shapping_DBEntities();

        // GET: Customer
        public ActionResult Index()
        {
            return View(db.customer_tb.ToList());
        }
        public ActionResult Product()
        {
            return View();
        }

        // GET: Customer/Details/5

        public ActionResult Login(Project_2.customer_tb avm)
        {
            using (Shapping_DBEntities db = new Shapping_DBEntities())
            {
                var ad = db.admin_tb.Where(x => x.Mobile_Number == avm.MobileNumber && x.Password == avm.Password).FirstOrDefault();
                if (ad == null)
                {
                    return View("Login", avm);
                }
                else
                {
                    Session["Admin_Name"] = ad.First_Name.ToString();
                    return Redirect("http://localhost:4200/Home");


                }
            }
        }
        // GET: Customer/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Customer/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Customer_Id,FirstName,LastName,MobileNumber,Email_Id,Password,Confirm_Password")] customer_tb customer_tb)
        {
            if (ModelState.IsValid)
            {
                db.customer_tb.Add(customer_tb);
                db.SaveChanges();
                return RedirectToAction("Login");
            }

            return View(customer_tb);
        }

        // GET: Customer/Edit/5
        //public ActionResult Edit(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    customer_tb customer_tb = db.customer_tb.Find(id);
        //    if (customer_tb == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(customer_tb);
        //}

        //// POST: Customer/Edit/5
        //// To protect from overposting attacks, enable the specific properties you want to bind to, for 
        //// more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit([Bind(Include = "Customer_Id,FirstName,LastName,MobileNumber,Email_Id,Password,Confirm_Password")] customer_tb customer_tb)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.Entry(customer_tb).State = EntityState.Modified;
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }
        //    return View(customer_tb);
        //}

        //// GET: Customer/Delete/5
        //public ActionResult Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    customer_tb customer_tb = db.customer_tb.Find(id);
        //    if (customer_tb == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(customer_tb);
        //}

        //// POST: Customer/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public ActionResult DeleteConfirmed(int id)
        //{
        //    customer_tb customer_tb = db.customer_tb.Find(id);
        //    db.customer_tb.Remove(customer_tb);
        //    db.SaveChanges();
        //    return RedirectToAction("Index");
        //}

        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing)
        //    {
        //        db.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}
    }
}
