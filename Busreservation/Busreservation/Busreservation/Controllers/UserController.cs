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
using Syncfusion.HtmlConverter;
using Syncfusion.Pdf;
using System.IO;
using SelectPdf;

namespace Busreservation.Controllers
{
    public class UserController : Controller
    {
        private readonly BusReservationContext db;
        public int noOfSeats;
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
                        HttpContext.Session.SetString("Uid", model.UserMail);
                        TempData["id"] = model.UserMail;
                        return RedirectToAction("Search", "Passenger");


                    }
                    else
                    {
                        ViewBag.Message = "Invalid  User id or Password";

                        return View();
                    }
                }
            }
        }
        public IActionResult Book(int id)
        {
            // DisplayBus dis = new DisplayBus();
            // TempData["busname"] = dis.BusName;
            BookingDetails p = new BookingDetails();
            p.PassengerDetails = new List<PassengerDetails>();
            p.BusId = id;
            p.BookedOn = DateTime.Now;
            p.Doj = Convert.ToDateTime(TempData["doj"]);
            TempData.Keep("doj");
            p.TravelFrom = Convert.ToString(TempData["Src"]);
            TempData.Keep("Src");
            p.TravelTo = Convert.ToString(TempData["Des"]);
            TempData.Keep("Des");
            p.UserId = Convert.ToString(TempData["id"]);
            TempData.Keep("id");
            var fare = (from f in db.BusRoutes
                        where f.BusId == id
                        select f.Fare).SingleOrDefault();
            p.Fare = Convert.ToDouble(fare);
            var noOfseats = TempData["noOfSeats"] != null ? Convert.ToInt32(TempData["noOfSeats"]) : 0;
            TempData.Keep("noOfSeats");
            for (int i = 1; i <= noOfseats; i++)
            {
                var passengerdetail = new PassengerDetails();
                passengerdetail.Seatno = "A" + i;
                p.PassengerDetails.Add(passengerdetail);
            }


            ViewBag.Uid = HttpContext.Session.GetString("Uid");

            return View(p);
        }

        [HttpPost]

        public IActionResult Book(BookingDetails book)
        {
            if (ModelState.IsValid)
            {
                var userid = (from u in db.UserDetails
                              where u.UserMail == book.UserId
                              select u.UserId).SingleOrDefault();

                for (int i = 0; i < book.PassengerDetails.Count(); i++)
                {
                    var pnrdetail = new Pnrdetail()
                    {
                        BusId = book.BusId,
                        BookedOn = book.BookedOn,
                        Doj = book.Doj,
                        Fare = book.Fare,
                        PassAge = book.PassengerDetails[i].PassAge,
                        PassGender = book.PassengerDetails[i].PassGender,
                        PassName = book.PassengerDetails[i].PassName,
                        Seatno = book.PassengerDetails[i].Seatno,
                        TravelFrom = book.TravelFrom,
                        TravelTo = book.TravelTo,
                        UserId = userid

                    };
                    db.Pnrdetails.Add(pnrdetail);

                }


                db.SaveChanges();

                return RedirectToAction("Payment", "User", new { @id = book.BusId, });
            }
            return RedirectToAction("Error");

        }

        public IActionResult Payment(int id)
        {
            ViewBag.Uid = HttpContext.Session.GetString("Uid");
            TransactDetail t = new TransactDetail();
            //Pnrdetail p = new Pnrdetail();
            //Search seat = new Search();
            t.TransactTime = DateTime.Now;

            t.UserId = Convert.ToString(TempData["id"]);
            TempData.Keep("id");
            var userid = (from u in db.UserDetails
                          where u.UserMail == t.UserId
                          select u.UserId).SingleOrDefault();

            var pnr = (from p in db.Pnrdetails
                       where p.BusId == id && p.UserId == userid
                       orderby p.BookedOn descending
                       select p.PnrNo).FirstOrDefault();
            t.PnrNo = pnr;
            var fare = (from f in db.BusRoutes
                        where f.BusId == id
                        select f.Fare).SingleOrDefault();
            //var noOfseats=  TempData["noOfSeats"];
            //var noOfseats = TempData["noOfSeats"].Key;//like this
            //if (noOfseats.Count > 0)
            var noOfseats = Convert.ToInt32(TempData["noOfSeats"]);
            TempData.Keep("noOfSeats");
            //int count = Model.PassengerDetails?.Count() > 0 ? Model.PassengerDetails.Count() : 0;

            //var noOfseats = TempData["noOfSeats"] != null ? Convert.ToInt32(TempData["noOfSeats"]) : 0;
            t.TotalAmount = fare * noOfseats;

            return View(t);
        }

        [HttpPost]

        public IActionResult Payment(TransactDetail transaction)
        {
            if (ModelState.IsValid)
            {
                var userid = (from u in db.UserDetails
                              where u.UserMail == transaction.UserId
                              select u.UserId).SingleOrDefault();

                var pnrno = (from p in db.Pnrdetails
                             where p.PnrNo == transaction.PnrNo
                             select p.PnrNo).SingleOrDefault();
                var transdetail = new TransactDetail()
                {
                    PnrNo = transaction.PnrNo,
                    UserId = userid,
                    PaymentOption = transaction.PaymentOption,
                    Paymentstatus = transaction.Paymentstatus,
                    TransactTime = transaction.TransactTime,
                    TotalAmount = transaction.TotalAmount

                };

                db.TransactDetails.Add(transdetail);
                db.SaveChanges();
                return RedirectToAction("PNRBooking", new { @id = userid });

            }

            return RedirectToAction("Error");
        }

        public IActionResult Seat()
        {
            return View();
        }

        //public IActionResult MyBookings()
        //{
        //    //loginviewmodel model
        //    //ViewBag.Uid = HttpContext.Session.GetString("Uid");

        //    //var upnr = new List<Pnrdetail>();
        //    //var ipnr = (from p in db.Pnrdetails join u in db.UserDetails on p.UserId equals u.UserId
        //    //            where u.UserMail == model.UserMail
        //    //            select p).ToList();

        //    //upnr = ipnr.ToList(); 
        //    //upnr
        //    return View();

        //}

        public IActionResult MyBooking()
        {
            ViewBag.Uid = HttpContext.Session.GetString("Uid");
            var uid = TempData["id"] != null ? TempData["id"] : 0;
            TempData.Keep("id");
            var upnr = new List<Pnrdetail>();
            var ipnr = (from p in db.Pnrdetails
                        join u in db.UserDetails on p.UserId equals u.UserId
                        where u.UserMail == uid
                        select p).ToList();
            upnr = ipnr.ToList();
            return View(upnr);
        }

        public IActionResult PNRBooking(string id)
        {
            ViewBag.Uid = HttpContext.Session.GetString("Uid");
            var pnr = new List<Pnrdetail>();
            var upnr = (from p in db.Pnrdetails
                        where p.UserId == id
                        select p).ToList();
            pnr = upnr.ToList();
            return View(pnr);
        }

        public IActionResult PNRDetails(int id)
        {
            ViewBag.Uid = HttpContext.Session.GetString("Uid");
            Pnrdetail pnr = db.Pnrdetails.Find(id);
            var busnum = (from b in db.Pnrdetails
                          join n in db.BusMasters on b.BusId equals n.BusId
                          select n.RegistrationNo).FirstOrDefault();
            var busname = (from b in db.Pnrdetails
                           join n in db.BusMasters on b.BusId equals n.BusId
                           select n.BusName).FirstOrDefault();
            ViewData["busno"] = busnum;
            ViewData["busname"] = busname;
            return View(pnr);
        }

        public IActionResult PrintPdf(string html)
        {
            HtmlToPdf converter = new HtmlToPdf();
            html = html.Replace("start", ">").Replace("end", ">");
            SelectPdf.PdfDocument doc = converter.ConvertHtmlString(html);

            //doc.Save($@"{AppDomain.CurrentDomain.BaseDirectory}\url.pdf");

            byte[] pdfFile = doc.Save();
            doc.Close();

            return File(pdfFile, "application/pdf");
        }

        public IActionResult DeletePNR(int id)
        {
            ViewBag.Uid = HttpContext.Session.GetString("Uid");
            Pnrdetail pnr = db.Pnrdetails.Find(id);
            db.Pnrdetails.Remove(pnr);
            db.SaveChanges();
            return RedirectToAction("PNRBooking");
        }

        //public IActionResult PNRDetails(string Print)
        //{
        //    //html to pdf conversion code
        //    //HtmlToPdfConverter converter = new HtmlToPdfConverter();
        //    //WebKitConverterSettings = new WebKitConverterSettings();
        //    //settings.WebKitPath = Path.Combine(_hostingEnvironment.ContentRootPath, "QtBinariesWindows");
        //    //converter.ConverterSettings = settings;

        //    //PdfDocument document = converter.Convert("");

        //    return View();
        //}

        //public IActionResult ExportToPDF(object _hostingEnvironment)
        //{
        //    //Initialize the HTML to PDF converter with the Blink rendering engine. 
        //    HtmlToPdfConverter htmlConverter = new HtmlToPdfConverter(HtmlRenderingEngine.Blink);

        //    BlinkConverterSettings settings = new BlinkConverterSettings();
        //    settings.ViewPortSize = new Syncfusion.Drawing.Size(1440, 0);

        //    //Set the BlinkBinaries folder path. 
        //    settings.BlinkPath = Path.Combine(_hostingEnvironment.ContentRootPath, "BlinkBinariesWindows");

        //    //Assign Blink settings to HTML converter.
        //    htmlConverter.ConverterSettings = settings;

        //    //Get the current URL.
        //    string url = Microsoft.AspNetCore.Http.Extensions.UriHelper.GetEncodedUrl(HttpContext.Request);

        //    url = url.Substring(0, url.LastIndexOf('/'));

        //    //Convert URL to PDF.
        //    PdfDocument document = htmlConverter.Convert(url);
        //    MemoryStream stream = new MemoryStream();
        //    document.Save(stream);
        //    return File(stream.ToArray(), System.Net.Mime.MediaTypeNames.Application.Pdf, "MVC_view_to_PDF.pdf");
        //}











    }
}
