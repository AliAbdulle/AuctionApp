using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AuctionApp.Controllers
{
    public class AuctionController : Controller
    {
        // GET: Auction
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult TempDataDamo()
        {
            TempData["SucessMessage"] = "The Action Sucessed";

            return RedirectToAction("Index");
        }

        public ActionResult Auction()
        {
            var auction = new AuctionApp.Models.Auction()
            {
                Title = "Example Auction",
                Description = "This is new product",
                StartTime = DateTime.Now,
                EndTime = DateTime.Now.AddDays(7),
                StartPrice = 1.00m,
                CurrentPrice = null
            };
         
            return View(auction);
        }
    }
}