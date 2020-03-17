using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace T1908E_WAD.Models
{
    public class MyDatabaseContext : DbContext
    {
        public MyDatabaseContext() : base("MyConnectionString")
        {
        }
        public DbSet<Employee> Employees { get; set; }
    }
}