using AuctionApp.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
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
            var db = new AuctionDataContext();
            var auctions = db.Auctions.ToArray();

            return View(auctions);
        }


        public ActionResult Auction(long id)
        {
            var db = new AuctionDataContext();
            var auction = db.Auctions.Find(id);

            
            return View(auction);
        }

        [HttpGet]
        public ActionResult Create()
        {
            // Drop down category
            var categoryList = new SelectList(new[] { "Books", "Pens", "Electronics" });
            ViewBag.CategoryList = categoryList;
            return View();
        }


       [HttpPost]
        public ActionResult Create([Bind(Exclude = "CurrentPrice")]Models.Auction auction)
        {
            if (ModelState.IsValid)
            {
                //Save database
                var db = new AuctionDataContext();
                db.Auctions.Add(auction);
                db.SaveChanges();

                return RedirectToAction("Index");
            }

            return Create();
        }
        public ActionResult Edit()
        {
            return View();
        }
    }
}