using Busreservation.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
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
                           where b.BusDestination == s.Destination && b.BusSource == s.Source && m.BusStatus==true
                           select new DisplayBus
                           {
                               BusId = b.BusId,
                               RouteId = b.RouteId,
                               BusName = m.BusName,
                               BusCondition = m.BusCondition,
                               BusSource = b.BusSource,
                               BusDestination = b.BusDestination,
                               Fare=b.Fare
                           }).ToList();
            //var fare = (from b in bus
            //            select b.Fare).FirstOrDefault();
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
            TempData["noOfSeats"] = s.TotalSeats;
            //TempData["fare"] = fare;
            
            //TempData["busFare"]=


            return View(bus);
        }

        public IActionResult SendMail()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SendMail(string receiver, string subject, string message)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var senderEmail = new MailAddress("manojkumar.v@dotnetethics.com", "Jamil");
                    var receiverEmail = new MailAddress(receiver, "Receiver");
                    var password = "Manoj@741";
                    var sub = subject;
                    var body = message;
                    var smtp = new SmtpClient
                    {
                        Host = "smtp.gmail.com",
                        Port = 587,
                        EnableSsl = true,
                        DeliveryMethod = SmtpDeliveryMethod.Network,
                        UseDefaultCredentials = false,
                        Credentials = new NetworkCredential(senderEmail.Address, password)
                    };
                    using (var mess = new MailMessage(senderEmail, receiverEmail)
                    {
                        Subject = subject,
                        Body = body
                    })
                    {
                        smtp.Send(mess);
                    }
                    return View();
                }
            }
            catch (Exception)
            {
                ViewBag.Error = "Some Error";
            }
            return View();
        }
    }
}

