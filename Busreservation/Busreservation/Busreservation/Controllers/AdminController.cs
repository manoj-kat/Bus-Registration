using Busreservation.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Busreservation.Controllers
{
    
    public class AdminController : Controller
    {
     
        private readonly BusReservationContext db;
        public AdminController(BusReservationContext context)
        {
            db = context;
        }
        
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Admin admin)
        {
           
            

                var adminId = "admin";
                var adminPassword = "admin";
                if (admin.adminId == adminId && admin.adminpass == adminPassword)
                {
                    return RedirectToAction("BusRoute", "Admin");

                }
                else
                {
                    ViewBag.error = "Invalid Access...";
                    return View();
                }
               
           
           
            
        }

        #region BusRoute Details
        public IActionResult BusRoute()
        {
            return View(db.BusRoutes.ToList());
        }
        
        public IActionResult AddBusRoute()
        {
            var busid = (from b in db.BusMasters
                      where b.BusStatus == true
                      select b.BusId).ToList();
            busid = Convert.ToInt32( ViewData["BusId"]);
            ViewData["BusId"] = new SelectList(busid, "BusId", "BusId");
            return View();
        }
        [HttpPost]
        public IActionResult AddBusRoute(BusRoute route)
        {
            if (ModelState.IsValid)
            {
                var br = (from b in db.BusMasters
                          join r in db.BusRoutes on b.BusId equals r.BusId
                          where b.BusStatus == true
                          select r);
                db.BusRoutes.Add(route);
                db.SaveChanges();
                return RedirectToAction("BusRoute");
            }
            return RedirectToAction("Error");
        }
        
        public IActionResult Edit(string id)
        {
            ViewData["BusId"] = new SelectList(db.BusMasters, "BusId", "BusId");
            BusRoute route = db.BusRoutes.Find(id);
            return View(route);
        }
        [HttpPost]
        public IActionResult Edit(BusRoute br)
        {
            if (ModelState.IsValid)
            {


                BusRoute route = db.BusRoutes.Find(br.RouteId);

                route.BusId = br.BusId;
                route.BusSource = br.BusSource;
                route.BusDestination = br.BusDestination;
                route.Fare = br.Fare;
                db.SaveChanges();
                return RedirectToAction("BusRoute");
            }
            return RedirectToAction("Error");

        }

        public IActionResult Delete(string id)
        {
            BusRoute route = db.BusRoutes.Find(id);
            db.BusRoutes.Remove(route);
            db.SaveChanges();
            return RedirectToAction("BusRoute");
        }

        public IActionResult Details(string id)
        {
            BusRoute route = db.BusRoutes.Find(id);
            return View(route);
        }
        #endregion

        #region BusMaster Details
        public IActionResult BusMaster()
        {
            return View(db.BusMasters.ToList());
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(BusMaster bus)
        {
            if (ModelState.IsValid)
            {
                db.BusMasters.Add(bus);
                //TempData["BusName"] = bus.BusName;
                db.SaveChanges();
                return RedirectToAction("BusMaster");
            }
            return RedirectToAction("Error");
        }

        public IActionResult EditBus(int id)
        {
            BusMaster bus = db.BusMasters.Find(id);
            return View(bus);
        }
        [HttpPost]
        public IActionResult EditBus(BusMaster b)
        {
            if (ModelState.IsValid)
            {
                BusMaster bus = db.BusMasters.Find(b.BusId);

                bus.BusName = b.BusName;
                bus.RegistrationNo = b.RegistrationNo;
                bus.BusCondition = b.BusCondition;

                db.SaveChanges();
                return RedirectToAction("BusMaster");
            }
            return RedirectToAction("Error");

        }

        public IActionResult DeleteBus(int id)
        {
            BusMaster bus = db.BusMasters.Find(id);
            BusMaster status = (from b in db.BusMasters where b.BusId == id select b).SingleOrDefault();
            status.BusStatus = false;
            //db.BusMasters.Add(status);
            db.SaveChanges();
            return RedirectToAction("BusMaster");
        }

        public IActionResult BusDetails(int id)
        {
            BusMaster bus = db.BusMasters.Find(id);
            return View(bus);
        }
        #endregion

        #region Trip Details
        //Trip Details
        public IActionResult TripDetails()
        {
            return View(db.TripDetails.ToList());
        }
        public IActionResult CreateTrip()
        {
            ViewData["RouteId"] = new SelectList(db.BusRoutes, "RouteId", "RouteId");
            ViewData["BusId"] = new SelectList(db.BusMasters, "BusId", "BusId");
            ViewData["DriverId"] = new SelectList(db.Drivers, "DriverId", "DriverId");
            return View();
        }
        [HttpPost]
        public IActionResult CreateTrip(TripDetail trip)
        {
            if (ModelState.IsValid)
            {
                db.TripDetails.Add(trip);
                db.SaveChanges();
                return RedirectToAction("TripDetails");
            }
            return RedirectToAction("Error");
        }

        public IActionResult EditTrip(int id)
        {
            TripDetail trip = db.TripDetails.Find(id);
            return View(trip);
        }
        [HttpPost]
        public IActionResult EditTrip(TripDetail td)
        {
            if (ModelState.IsValid)
            {
                TripDetail trip = db.TripDetails.Find(td.TripCode);
                trip.RouteId = td.RouteId;
                trip.BusId = td.BusId;
                trip.DriverId = td.DriverId;
                trip.TripDate = td.TripDate;
                trip.NoOfSeatsBooked = td.NoOfSeatsBooked;
                db.SaveChanges();
                return RedirectToAction("TripDetails");
            }
            return RedirectToAction("Error");

        }

        public IActionResult DeleteTrip(int id)
        {
            TripDetail trip = db.TripDetails.Find(id);
            db.TripDetails.Remove(trip);
            db.SaveChanges();
            return RedirectToAction("TripDetails");
        }

        public IActionResult DetailsTrip(int id)
        {
            TripDetail trip = db.TripDetails.Find(id);
            return View(trip);
        }
        #endregion

        #region Driver Details
        //Driver
        public IActionResult Driver()
        {
            return View(db.Drivers.ToList());
        }
        public IActionResult CreateDriver()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateDriver(Driver driver)
        {
            if (ModelState.IsValid)
            {
                db.Drivers.Add(driver);
                db.SaveChanges();
                return RedirectToAction("Driver");
            }
            return RedirectToAction("Error");
        }

        public IActionResult EditDriver(int id)
        {
            Driver driver = db.Drivers.Find(id);
            return View(driver);
        }
        [HttpPost]
        public IActionResult EditDriver(Driver d)
        {
            if (ModelState.IsValid)
            {
                Driver driver = db.Drivers.Find(d.DriverId);

                driver.DriverName = d.DriverName;
                driver.DriverAge = d.DriverAge;
                driver.DriverGender = d.DriverGender;

                db.SaveChanges();
                return RedirectToAction("Driver");
            }
            return RedirectToAction("Error");

        }

        public IActionResult DeleteDriver(int id)
        {
            Driver driver = db.Drivers.Find(id);
            db.Drivers.Remove(driver);
            db.SaveChanges();
            return RedirectToAction("Driver");
        }

        public IActionResult DriverDetails(int id)
        {
            Driver driver = db.Drivers.Find(id);
            return View(driver);
        }

        #endregion

    }
}
