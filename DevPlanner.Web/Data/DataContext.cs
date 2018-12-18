using DevPlanner.Web.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DevPlanner.Web.Data
{
    public class DataContext: DbContext
    {
        public DataContext()
           : base("DataContext")
        {
            //Database.Log = msg => Debug.WriteLine(msg);
            Database.SetInitializer<DataContext>(null);
        }
        public DbSet<Ticket> Tickets { get; set; }
    }
}