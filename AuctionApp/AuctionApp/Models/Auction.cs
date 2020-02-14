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
        [DataType(DataType.ImageUrl)]
        [Display(Name = "ImageUrl")]
        public string ImageUrl { get; set; }
        [DataType(DataType.DateTime)]
        [Display(Name = "Start Time")]
        public DateTime StartTime { get; set; }
        [DataType(DataType.DateTime)]
        [Display(Name = "End Time")]
        public DateTime EndTime { get; set; }

        [DataType(DataType.Currency)]
        [Display(Name = "Start Price")]
        public Decimal StartPrice { get; set; }
        [DataType(DataType.Currency)]
        [Display(Name = "Currency Bid Price")]
        public Decimal? CurrentPrice { get; set; }


    }
}