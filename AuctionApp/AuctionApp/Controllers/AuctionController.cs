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
            var auction = new[] {
                new Models.Auction()
            {
                Title = "Example Auction #1",
                Description = "This is new product",
                StartTime = DateTime.Now,
                EndTime = DateTime.Now.AddDays(7),
                StartPrice = 1.00m,
                CurrentPrice = null
            },
                new Models.Auction()
            {
                Title = "Example Auction #2",
                Description = "This is new product",
                StartTime = DateTime.Now,
                EndTime = DateTime.Now.AddDays(7),
                StartPrice = 100m,
                CurrentPrice = 30m
            },
                new Models.Auction()
            {
                Title = "Example Auction #3",
                Description = "This is new product",
                StartTime = DateTime.Now,
                EndTime = DateTime.Now.AddDays(7),
                StartPrice = 10.00m,
                CurrentPrice = 24m
            },
        };
            return View(auction);
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
        [HttpGet]
        public ActionResult Create()
        {
            var categoryList = new SelectList(new[] { "Books", "Pens", "Electronics" });
            ViewBag.CategoryList = categoryList;
            return View();
        }

        public ActionResult Post()
        {
            return View();
        }
    }
}