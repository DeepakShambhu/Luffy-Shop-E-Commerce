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
    public class AdminController : Controller
    {
        private Shapping_DBEntities db = new Shapping_DBEntities();
        private ShoppingDBEntities db2 = new ShoppingDBEntities();
        private ShoppingDB2Entities db3 = new ShoppingDB2Entities();

        // GET: Admin
        public ActionResult Index()
        {
            return View(db.admin_tb.ToList());
        }
  

        public ActionResult Product()
        {
            return View();
        }
        // GET: Admin/Login
     
        public ActionResult Login(Project_2.admin_tb avm)
        {
            using (Shapping_DBEntities db = new Shapping_DBEntities())
            {
                var ad = db.admin_tb.Where(x => x.Mobile_Number == avm.Mobile_Number && x.Password == avm.Password).FirstOrDefault();
                if (ad == null)
                {
                    return View("Login", avm);
                }
                else
                {
                    Session["Admin_Name"] = ad.First_Name.ToString();
                    return RedirectToAction("AdminPage");
                    

                }
            }
        }
        // GET: Admin/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Admin_Id,First_Name,Last_Name,Mobile_Number,Email_Id,Password,Confirm_Password")] admin_tb admin_tb)
        {
            if (ModelState.IsValid)
            {
                db.admin_tb.Add(admin_tb);
                db.SaveChanges();
                return RedirectToAction("Login");
            }

            return View(admin_tb);
        }
       
        public ActionResult AdminPage()
        {
            return View();
        }

        //// GET: Admin/Edit/5
        //public ActionResult Edit(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    admin_tb admin_tb = db.admin_tb.Find(id);
        //    if (admin_tb == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(admin_tb);
        //}

        //// POST: Admin/Edit/5
        //// To protect from overposting attacks, enable the specific properties you want to bind to, for 
        //// more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit([Bind(Include = "Admin_Id,First_Name,Last_Name,Mobile_Number,Email_Id,Password,Confirm_Password")] admin_tb admin_tb)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.Entry(admin_tb).State = EntityState.Modified;
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }
        //    return View(admin_tb);
        //}

        //// GET: Admin/Delete/5
        //public ActionResult Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    admin_tb admin_tb = db.admin_tb.Find(id);
        //    if (admin_tb == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(admin_tb);
        //}

        //// POST: Admin/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public ActionResult DeleteConfirmed(int id)
        //{
        //    admin_tb admin_tb = db.admin_tb.Find(id);
        //    db.admin_tb.Remove(admin_tb);
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
        public ActionResult ListSuppliers()
        {
            return View(db3.Suppliers_tb.ToList());
        }
        public ActionResult ListProducts()
        {
            return View(db2.Products.ToList());
        }
    }
}
