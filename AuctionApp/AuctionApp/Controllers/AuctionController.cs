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

        [HttpPost]
        public ActionResult Bid(Bid bid)
        {
            var db = new AuctionDataContext();
            var auction = db.Auctions.Find(bid.AuctionId);

            if (auction == null)
            {
                ModelState.AddModelError("AuctionId", "Auction Not found");
            }
            else if (auction.CurrentPrice >= bid.Amount)
            {
                ModelState.AddModelError("Amount", "Bid amount must be exceed current bid");
            }
            else
            {
                bid.Username = User.Identity.Name;
                auction.Bids.Add(bid);
                auction.CurrentPrice = bid.Amount;
                db.SaveChanges();
            }
            return View(bid);
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