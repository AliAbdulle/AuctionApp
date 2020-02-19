using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AuctionApp.Models
{
    public class AuctionDataContext : DbContext
    {
        public DbSet<Auction> Auctions { get; set; }

        static AuctionDataContext()
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<AuctionDataContext>());
        }
    }
}