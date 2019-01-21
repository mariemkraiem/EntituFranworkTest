using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using TestEntityFramework.Models;

namespace TestEntityFramework.Context
{
    public class MyDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Project> Projects { get; set; }


        public MyDbContext() : base()
        {

        }
    }
}