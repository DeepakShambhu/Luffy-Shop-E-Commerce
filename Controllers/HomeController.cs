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
    public class HomeController : Controller
    {
        private Shapping_DBEntities db = new Shapping_DBEntities();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Product()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        // GET: oder_tb/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: oder_tb/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Order_Id,Product_Name,Name,Address,Landmark,City,State,Pincode")] oder_tb oder_tb)
        {
            if (ModelState.IsValid)
            {
                db.oder_tb.Add(oder_tb);
                db.SaveChanges();
                return RedirectToAction("Confirm");
            }

            return View(oder_tb);
        }

        public ActionResult Login(Project_2.Suppliers_tb avm)
        {
            using (ShoppingDB2Entities db = new ShoppingDB2Entities())
            {
                var ad = db.Suppliers_tb.Where(x => x.Mobile_Number == avm.Mobile_Number && x.Password == avm.Password).FirstOrDefault();
                if (ad == null)
                {
                    return View("Login", avm);
                }
                else
                {
                    Session["Supplier_Id"] = ad.Supplier_Id.ToString();
                    return Redirect("http://localhost:55971/");


                }
            }
        }
        public ActionResult Confirm() 
        { 
            return View();
        }
    }
}