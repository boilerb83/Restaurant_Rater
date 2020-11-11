using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Restaurant_Rater.Models
{
    public class Restaurant
    {
        public int RestaurantID { get; set; }
        public int Name { get; set; }
        public int Address { get; set; }
        public int Rating { get; set; }

    }

    public class RestaurantDbContext : DbContext
    { 
        public DbSet<Restaurant> Restaurants { get; set; }
    }
}