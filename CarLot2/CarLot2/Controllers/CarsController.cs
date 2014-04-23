using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using System.Xml;
using CarLot2.Models;
using System.IO;


namespace CarLot2.Controllers
{
    public class CarsController : Controller
    {
        private CarDBContext db = new CarDBContext();

        //public ActionResult IsChecked()
        //{
        //    bool ischecked = 
            
        //    return View(model);
        //}

        // GET: /Cars/
        public ActionResult Index(string cmake, string searchString)
        {
            var MakeLst = new List<string>();

            var MakeQry = from d in db.Cars
                          orderby d.Make
                          select d.Make;

            MakeLst.AddRange(MakeQry.Distinct());
            ViewBag.cmake = new SelectList(MakeLst);

            //var boollst = new List<bool>();

            //var boolqry = from x in db.Cars
            //              where x.Checked.Equals(true)
            //              select x;
            //boollst.AddRange(boolqry.Distinct())




            var cars = from m in db.Cars
                       select m;

            if (!String.IsNullOrEmpty(searchString))
            {
                cars = cars.Where(s => s.Model.Contains(searchString));

            }
            if (!string.IsNullOrEmpty(cmake))
            {
                cars = cars.Where(x => x.Make == cmake);
            }

            return View(cars);

        }

        public ActionResult User()
        {
            return View();
        }

        // GET: /Cars/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Car car = db.Cars.Find(id);
            if (car == null)
            {
                return HttpNotFound();
            }
            return View(car);
        }
        // GET: /Cars/Create
        public ActionResult Create()
        {
            return View();
        }
        // POST: /Cars/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="ID,carID,Checked,Year,Make,Model,Mileage,ExtColor,IntColor,Price")] Car car)
        {
            if (ModelState.IsValid)
            {
                db.Cars.Add(car);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(car);
        }

        // GET: /Cars/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Car car = db.Cars.Find(id);
            if (car == null)
            {
                return HttpNotFound();
            }
            return View(car);
        }

        // POST: /Cars/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="ID,carID,Checked,Year,Make,Model,Mileage,ExtColor,IntColor,Price")] Car car)
        {
            if (ModelState.IsValid)
            {
                db.Entry(car).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(car);
        }

        // GET: /Cars/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Car car = db.Cars.Find(id);
            if (car == null)
            {
                return HttpNotFound();
            }
            return View(car);
        }

        // POST: /Cars/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Car car = db.Cars.Find(id);
            db.Cars.Remove(car);
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

        public static DataSet getCarEconmy(string carId)
        {
            DataSet ds = new DataSet();
            String BASE_URL = "http://www.fueleconomy.gov/ws/rest/vehicle/";
            String url = BASE_URL + carId;

            using (var w = new WebClient())
            {
                var xml_data = string.Empty;
                try
                {
                    xml_data = w.DownloadString(url);
                    ds.ReadXml(new XmlTextReader(new StringReader(xml_data)));
                }
                catch (Exception)
                {
                    Console.Out.WriteLine("Failed to download url: " + url);
                }
            }
            return ds;
        }
    }
}
