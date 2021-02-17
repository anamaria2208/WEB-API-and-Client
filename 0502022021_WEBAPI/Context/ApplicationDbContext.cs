using _0502022021_WEBAPI.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace _0502022021_WEBAPI.Context
{
    public class ApplicationDbContext  : DbContext
    {
        public ApplicationDbContext() : base("Baza")
        {
        }


        public DbSet<Film> Film { get; set; }
    }
}