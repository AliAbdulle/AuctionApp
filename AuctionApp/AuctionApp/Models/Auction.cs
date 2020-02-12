using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AuctionApp.Models
{
    public class Auction
    {
        public long Id { get; set; }
        
        public string Title { get; set; }

        public string Description { get; set; }

        public string ImageUrl { get; set; }

        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }


        public Decimal StartPrice { get; set; }

        public Decimal? CurrentPrice { get; set; }


    }
}