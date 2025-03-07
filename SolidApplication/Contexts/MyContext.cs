using SolidApplication.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;


namespace SolidApplication.Context
{
    public class MyContext:DbContext
    {
        public MyContext():base("name=MyContext")
        {

        }

        public DbSet<Models.Task> Tasks { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
