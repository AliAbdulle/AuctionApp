using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AuctionApp.Models
{
    public class Auction
    {
        public long Id { get; set; }
        [Required ]
        public string Category { get; set; }
        [Required]
        public string Title { get; set; }

        public string Description { get; set; }

        public string ImageUrl { get; set; }
        [Required]
        public DateTime StartTime { get; set; }
        [Required]
        public DateTime EndTime { get; set; }

        [Required]
        public Decimal StartPrice { get; set; }

        public Decimal? CurrentPrice { get; set; }


    }
}