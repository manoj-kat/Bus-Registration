using Busreservation.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Busreservation.Controllers
{
    public class PassengerController : Controller
    {
        private readonly BusReservationContext db;
        public PassengerController(BusReservationContext context)
        {
            db = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Search()
        {
            ViewBag.Uid = HttpContext.Session.GetString("Uid");


            return View();
        }
        [HttpPost]
        public IActionResult Search(Search s)
        {

            return DisplayBus(s);
        }

        public IActionResult DisplayBus(Search s)
        {
            List<DisplayBus> bus = new List<DisplayBus>();
            bus = (from b in db.BusRoutes
                           join m in db.BusMasters on b.BusId equals m.BusId
                           where b.BusDestination == s.Destination && b.BusSource == s.Source
                           select new DisplayBus
                           {
                               BusId = b.BusId,
                               RouteId = b.RouteId,
                               BusName = m.BusName,
                               BusCondition = m.BusCondition,
                               BusSource = b.BusSource,
                               BusDestination = b.BusDestination
                           }).ToList();
           
            if(bus!=null && bus.Count>0)
            {
                foreach(var item in bus)
                {
                    item.Doj = s.DateOfJourney;
                }
            }
            ViewBag.Uid = HttpContext.Session.GetString("Uid");
            TempData["Doj"] = s.DateOfJourney;
            TempData["Src"] = s.Source;
            TempData["Des"] = s.Destination;
            
            return View(bus);
        }

        public IActionResult BookBus()
        {
            return View();
        }
    }
}

