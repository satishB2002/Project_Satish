using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace Project_Satish.Models
{
    public class ServicesContext : DbContext
    {
        public DbSet<Product> prod { get; set; }

    }
}