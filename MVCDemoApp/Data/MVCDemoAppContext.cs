using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MVCDemoApp.Models
{
    public class MVCDemoAppContext : DbContext
    {
        public MVCDemoAppContext (DbContextOptions<MVCDemoAppContext> options)
            : base(options)
        {
        }

        public DbSet<MVCDemoApp.Models.Employee> Employee { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().ToTable("tblEmployee");
            
        }
    }
}
