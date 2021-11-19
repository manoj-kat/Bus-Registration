using Busreservation.Models;
using Busreservation.View_Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Busreservation.Controllers
{
    public class UserController : Controller
    {
        private readonly BusReservationContext db;
        public UserController(BusReservationContext context)
        {
            db = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Register(UserDetail user)

        {
            if (ModelState.IsValid)
            {
                try
                {
                    db.UserDetails.Add(user);
                    db.SaveChanges();
                    return RedirectToAction("Login", "User");
                }
                catch (Exception)
                {
                    return RedirectToAction("Error");
                }
            }
            else
            {
                return View();
            }
        }



        public IActionResult Login()
        {

            return View();
        }

        //[HttpPost]
        //public async Task<ActionResult> Login(loginviewmodel model)
        //  {
        //    if (ModelState.IsValid)
        //    {
        //        var userdetails = await db.UserDetails
        //        .SingleOrDefaultAsync(m => m.UserMail == model.UserMail && m.UserPass == model.UserPass);
        //        if (userdetails == null)
        //        {
        //            ModelState.AddModelError("Password", "Invalid login attempt.");
        //            return View("Index");
        //        }
        //        TempData["UserMail"] = userdetails.UserMail;
        //    }

        //    return RedirectToAction("Search", "Passenger");
        //}

        [HttpPost]
        public ActionResult Login(loginviewmodel model)
        {
            if (model.UserMail == null || model.UserPass == null)
            {

                ViewBag.Message = "Username or Password cannot be empty";
                return View();
            }
            else
            {


                if (model.UserMail == null)
                {

                    ViewBag.Message = "Invalid User";

                    return View();
                }
                else if (model.UserPass == null)
                {
                    ViewBag.Message = "Invalid Password";

                    return View();

                }
                else
                {
                    var q = from p in db.UserDetails
                            where p.UserMail == model.UserMail && p.UserPass == model.UserPass
                            select p;
                    if (q.Any())

                    {
                        ViewBag.Message = "Login Successfull";
                        HttpContext.Session.SetString("Uid",model.UserMail);
                        TempData["id"] = model.UserMail;
                        return RedirectToAction("Search", "Passenger");


                    }
                    else
                    {
                        ViewBag.Message = "Invalid  User id and Password";

                        return View();
                    }
                }
            }
        }
        public IActionResult Book()
        {
            DisplayBus dis = new DisplayBus();
            TempData["busname"] = dis.BusName;

            Pnrdetail p = new Pnrdetail();
            
            p.BookedOn = DateTime.Now;
            p.Doj = Convert.ToDateTime(TempData["doj"]);
            TempData.Keep("doj");
            p.TravelFrom = Convert.ToString( TempData["Src"]);
            TempData.Keep("Src");
            p.TravelTo = Convert.ToString(TempData["Des"]);
            TempData.Keep("Des");
            p.UserId = Convert.ToString(TempData["id"]);
            TempData.Keep("id");
            p.BusName =Convert.ToString (TempData["busname"]);
            TempData.Keep("busname");

            ViewBag.Uid=HttpContext.Session.GetString("Uid");
          //  ViewData["UserId"] = TempData["id"];


            //ViewData["UserId"] = new SelectList(db.UserDetails, "UserId", "UserMail");
            //ViewData["BusId"] = new SelectList(db.BusMasters, "BusId", "BusName");
            return View(p);
        }

        public IActionResult Payment()
        {
            TransactDetail t = new TransactDetail();
            t.TransactTime = DateTime.Now;
            return View(t);
        }

        public IActionResult Seat()
        {
            return View();
        }



        
    }
}
